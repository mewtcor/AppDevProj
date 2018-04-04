using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS
{
    public class DrSearchPatientClass
    {
        //==================================================================================//
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        SqlDataReader rdr;
        //=================================================================================//

        public DataTable GetGridItems()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Patient", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                dt.Load(rdr);
                conn.Close();
                return dt;
            }
            else
            {
                MessageBox.Show("No data to show");
                dt = null;
                conn.Close();
                return dt;
            }            
        }

        //public String SearchName { get; set; }

        public DataTable SearchByName(string SearchName)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Patient WHERE Name LIKE @Name", conn);

            TextBox t = Application.OpenForms["DrSearchPatient"].Controls["txtSearch"] as  TextBox;
            cmd.Parameters.AddWithValue("Name", SearchName + "%");
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                conn.Close();
                return dt;
            }
            else
            {
                MessageBox.Show("No Data to show!");
                conn.Close();
                dt = null;
                return dt;
            }

        }
    }
}
