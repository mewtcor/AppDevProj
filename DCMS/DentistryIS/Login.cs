using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DentistryIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Load += new EventHandler(Login_Load);
        }
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DCMSdb"].ConnectionString;
        SqlDataReader rdr;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
          //validate blank txtfields
            string UName = txtUsername.Text;
            string Pword = txtPassword.Text;
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select * from Users where Username='" + UName + "' and Password = '" + Pword + "'", conn);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            conn.Open();
            var rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    string roleLevel = rd["UAccess"].ToString();

                    if (roleLevel == "Administrator")
                    {
                        Hide();
                        AdminDash adForm = new AdminDash();
                        adForm.Show();
                    }
                    else if (roleLevel == "Assistant")
                    {
                        Hide();
                        AssistantDash astForm = new AssistantDash();
                        astForm.Show();
                    }
                    else if(roleLevel=="Doctor")
                    {
                        Hide();
                        DoctorDash drForm = new DoctorDash();
                        drForm.Show();
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Whoops! Please check your login details and try again");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblUser.Text = Globals.CurrentUser;
            if (Globals.CurrentUser == "Administrator")
            {
                pnUpper.BackColor = System.Drawing.Color.LightSalmon;
                pnLower.BackColor = System.Drawing.Color.LightSalmon;

            }
            else if (Globals.CurrentUser == "Doctor")
            {
                pnUpper.BackColor = System.Drawing.Color.Teal;
                pnLower.BackColor = System.Drawing.Color.Teal;
            }
            else if (Globals.CurrentUser == "Assistant")
            {
                pnUpper.BackColor = System.Drawing.Color.CornflowerBlue;
                pnLower.BackColor = System.Drawing.Color.CornflowerBlue;
            }
        }

    }
}
