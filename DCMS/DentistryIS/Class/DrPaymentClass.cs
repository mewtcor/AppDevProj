using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DentistryIS
{
    class DrPaymentClass
    {
        //==============================================================================
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        //==============================================================================


        public DataTable DatFillDrCmb()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select Name from Dentist", conn);
            DataTable dt = new DataTable();
            conn.Open();
            var rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                conn.Close();
                return dt;
            }
            else
            {
                conn.Close();
                dt = null;
                return dt;
            }
        }
        public DataTable DatFillPartCmb()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select Service_Name from Service", conn);

            DataTable dt = new DataTable();
            conn.Open();
            var rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                conn.Close();
                return dt;
            }
            else
            {
                conn.Close();
                dt = null;
                return dt;
            }
        }
        public string DatDrID(string drName)
        {
            //Fill DentistID Textbox
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select * from Dentist where Name = '" + drName + "'", conn);
            conn.Open();
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string res = rd["DentistID"].ToString();
                conn.Close();
                return res;
            }
            conn.Close();
            return null;
        }
        public Tuple<string, string> DatCurDrInfo()
        {
            //string test = "Doctor Strange";
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select DentistID, Name from Dentist where Name = '" + Globals.CurrentUser + "'", conn);

            conn.Open();

            var rd = cmd.ExecuteReader();
            //if data found
            while (rd.Read())
            {
                string drid = rd["DentistID"].ToString();
                string drname= rd["Name"].ToString();
                conn.Close();
                return Tuple.Create(drid, drname);
            }
            conn.Close();
            return null;
        }
        public string datServAmount(string servname)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select Amount from Service where Service_Name = '" + servname + "'", conn);
            conn.Open();
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string amount = rd["Amount"].ToString();
                conn.Close();
                return amount;
            }
            conn.Close();
            return null;
        }
        public void Save(string did, string pid, string date, string allp, string ttotal)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO Bill (Dentist_ID, Patient_ID, Date, Service, Bill_Total) VALUES (@Dentist_ID, @Patient_ID, @Date, @Service, @Bill_Total)", conn);

            cmd.Parameters.AddWithValue("@Dentist_ID", did);
            cmd.Parameters.AddWithValue("@Patient_ID", pid);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Service", allp);
            cmd.Parameters.AddWithValue("@Bill_Total", ttotal);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Data Saved!");

            }
            conn.Close();
        }
    }
}
