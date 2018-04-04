using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS
{
    class DrPatientClass
    {
        //db connection declarations
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        SqlDataReader rdr;

        public DataTable GetAll()
        {
            //author: enzo
            //this method displays all data in grdpatient(gridview) when called
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
                MessageBox.Show("No Data to Show");
                dt = null;
                conn.Close();
                return dt;
            }
        }
        public void UpdatePatient(int ID, string Name, string Age, string Address, string Gender, int ContactNo, string DOB, string BloodGroup, string HealthProblem, Image Image )
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("UPDATE Patient Set Name=@Name, Age=@Age, Gender=@Gender, Address=@Address, ContactNo=@ContactNo, DOB=@DOB, BloodGroup=@BloodGroup, HealthProblem=@HealthProblem, Image=@Image WHERE Patient_ID=@Patient_ID", conn);

            cmd.Parameters.AddWithValue("@Patient_ID", ID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@BloodGroup", BloodGroup);
            cmd.Parameters.AddWithValue("@HealthProblem", HealthProblem);
            cmd.Parameters.AddWithValue("@Image", ConvertImageToBinary(Image));

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Saved!");

            }
            conn.Close();

            byte[] ConvertImageToBinary(Image img)
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();

                }
            }
        }

        public void AddPatient(int ID, string Name, string Age, string Address, string Gender, int ContactNo, string DOB, string BloodGroup, string HealthProblem, Image Image)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO Patient (Name, Age, Gender, Address, ContactNo, DOB, BloodGroup, HealthProblem, Image) VALUES (@Name, @Age, @Gender, @Address, @ContactNo, @DOB, @BloodGroup, @HealthProblem, @Image)", conn);

            cmd.Parameters.AddWithValue("@Patient_ID", ID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@BloodGroup", BloodGroup);
            cmd.Parameters.AddWithValue("@HealthProblem", HealthProblem);
            cmd.Parameters.AddWithValue("@Image", ConvertImageToBinary(Image));

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Saved!");

            }
            conn.Close();

            byte[] ConvertImageToBinary(Image img)
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();

                }
            }
        }
        public DataTable SearchByName()
        {
    
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Patient WHERE Name LIKE @Name", conn);

            cmd.Parameters.AddWithValue("Name", Globals.SearchedName + "%");
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
                MessageBox.Show("No Data to Show");
                dt = null;
                conn.Close();
                return dt;
            }
        }
        public void DelProc(string pid)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("DELETE FROM Patient WHERE Patient_ID=@Patient_ID", conn);
            cmd.Parameters.AddWithValue("@Patient_ID", pid);

            conn.Open();
            DialogResult dialogResult = MessageBox.Show("Sure?", "Delete Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(pid);
                cmd.ExecuteNonQuery();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
           
            conn.Close();
        }
    }
}
