using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS
{
    public class LoginClass
    {
        //Enzo
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        public string validateLogin(string username, string password, string uaccess)
        {
            //validate blank txtfields
            if (username.Equals(string.Empty).Equals(true) || password.Equals(string.Empty).Equals(true))
            {
                MessageBox.Show("Username or Password cannot be blank!");
                uaccess = "";
                return uaccess;
            }
            else
            {
                //db connection
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("select * from Users where Username='" + username + "' and Password = '" + password + "'", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                var rd = cmd.ExecuteReader();
                //if data found
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //set current user
                        Globals.CurrentUser = rd["Name"].ToString();
                        Globals.CurrentUserName = username;
                        string roleLevel = rd["UAccess"].ToString();
                        uaccess = rd["UAccess"].ToString();
                        return uaccess;
                        /**if (roleLevel == "Administrator")
                        {
                            Login frm = new Login();
                            frm.Close();
                            //show Admin dash
                            AdminDash adForm = new AdminDash();
                            adForm.Show();
                        }
                        else if (roleLevel == "Assistant")
                        {
                            Login frm = new Login();
                            frm.Close();
                            //show Assistant Dash
                            AssistantDash astForm = new AssistantDash();
                            astForm.Show();
                        }
                        else if (roleLevel == "Doctor")
                        {
                            Login frm = new Login();
                            frm.Close();
                            //show Doctor Dash
                            DoctorDash drForm = new DoctorDash();
                            drForm.Show();
                        }**/
                    }
                    return null;
                }
                else
                {
                    //if no data found
                    Login frm = new Login();

                    MessageBox.Show("Whoops! Please check your login details and try again");
                    frm.uname = "";
                    frm.pword = "";
                    username = "";
                    password = "";
                    uaccess = "";
                    return null;
                }
            }
        }
      
        private void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Tooth Fairy Dental";
            frm.BackgroundImageLayout = ImageLayout.Stretch;
            frm.BackgroundImage = Properties.Resources.thegeek;
            frm.Icon = Properties.Resources.toothico;
            Application.Run(frm);

        }

        public void InitSplash()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();

            //loading data
            string str = string.Empty;
            for (int i = 0; i < 25000; i++)
            {
                str += i.ToString();//Init data
            }
            //complete
            t.Abort();
        }
    }
}
