using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DentistryIS
{
    public partial class Login : Form
    {
        //Enzo
        public Login()
        {
            InitializeComponent();     
        }
        
        public string pword
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string uname
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //exit system
            System.Environment.Exit(0);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClass lclass = new LoginClass();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string uaccess = "";
            string UsrRole = lclass.validateLogin(username, password, uaccess);
           if (UsrRole == "Administrator")
            {
                Hide();
                AdminDash adForm = new AdminDash();
                adForm.Show();
                Hide();
            }
            else if (UsrRole == "Assistant")
            {
                Hide();
                //show Assistant Dash
                AssistantDash astForm = new AssistantDash();
                astForm.Show();
            }
            else if (UsrRole == "Doctor")
            {
                Hide();
                //show Doctor Dash
                DoctorDash drForm = new DoctorDash();
                drForm.Show();
            }
        }

       
        private void Login_Load(object sender, EventArgs e)
        {
            //LoginClass init = new LoginClass();
            //init.InitSplash();
            //this.Activate();
        }
    }
}
