using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistryIS
{
    class LoginProc
    {
        //database connection declarations
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
    }

    public void Test()
    {
        string UName = txtUsername.Text.Trim();
        string Pword = txtPassword.Text.Trim();
        //db connection
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select * from Users where Username='" + UName + "' and Password = '" + Pword + "'", conn);
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
        conn.Open();
        var rd = cmd.ExecuteReader();
        //if data found
        if (rd.HasRows)
        {
            while (rd.Read())
            {
                //set current user
                Globals.CurrentUser = rd["Name"].ToString();
                Globals.CurrentUserName = txtUsername.Text.Trim();
                string roleLevel = rd["UAccess"].ToString();

                if (roleLevel == "Administrator")
                {
                    Hide();
                    //show Admin dash
                    AdminDash adForm = new AdminDash();
                    adForm.Show();
                }
                else if (roleLevel == "Assistant")
                {
                    Hide();
                    //show Assistant Dash
                    AssistantDash astForm = new AssistantDash();
                    astForm.Show();
                }
                else if (roleLevel == "Doctor")
                {
                    Hide();
                    //show Doctor Dash
                    DoctorDash drForm = new DoctorDash();
                    drForm.Show();
                }

            }

        }

        else
        {
            //if no data found
            MessageBox.Show("Whoops! Please check your login details and try again");
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

    }
}
