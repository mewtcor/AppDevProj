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
     class DrAppointmentClass
    {
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        private SqlDataReader rdr;

        public DataTable GetAll()
        {
            Doctor.DrAppointments frm = new Doctor.DrAppointments();
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Appointment WHERE Dentist='" + Globals.CurrentUser + "'", conn);
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
                MessageBox.Show("No Data Appointments to Show");
                dt = null;
                conn.Close();
                return dt;
            }
        }
        public DataTable Get()
        {
            Doctor.DrAppointments frm = new Doctor.DrAppointments();
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Appointment WHERE Date= '"+ Globals.TempDate + "' AND Dentist='" + Globals.CurrentUser + "'", conn);
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
                MessageBox.Show("No Data Appointments to Show");
                dt = null;
                conn.Close();
                return dt;           
            }
        }

        public void InvShowByDate()
        {
            

        }
        
        private void NoGVData()
        {
            MessageBox.Show("No data to show");
        }
    }
}
