using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS
{
    public class CPWClass
    {
        SqlConnection conn;
        SqlCommand cmd;
        string connStr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        private SqlDataReader rdr;
        public bool DoesUsrExist(string name, string oldpw)
        {
            //validate blank oldpw textfield
            if (oldpw.Equals(string.Empty).Equals(true))
            {
                MessageBox.Show("Old Password cannot be blank!");
                return false;
            }
            else
            {
                //db connection
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("select * from Users where Name='" + name + "' and Password = '" + oldpw + "'", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Password", oldpw);
                conn.Open();
                var rd = cmd.ExecuteReader();
                //if data found
                if (rd.HasRows)
                {  
                    return true;
                }
                else
                {
                    MessageBox.Show("Please make sure you are typing in the correct password.");
                    return false;
                }
            }          
        }
        public void UpdateRec(string newPword, string name)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("UPDATE Users SET Password=@Password WHERE Name=@Name", conn);

            cmd.Parameters.AddWithValue("@Password", newPword);
            cmd.Parameters.AddWithValue("@Name", name);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Your password has been updated!");

            }
            conn.Close();
        }
    }
    
}
