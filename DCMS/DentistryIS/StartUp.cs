using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

   
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Globals.CurrentUser = "Administrator";
            this.Hide();
            Login ULogin = new Login();
            ULogin.Show();
        }
        public string SessionUser
        {
            get { return this.lblUser.Text; }
            set { this.lblUser.Text = value; }
        }


        private void btnAssistant_Click(object sender, EventArgs e)
        {
            Globals.CurrentUser = "Assistant";
            Hide();
            Login ULogin = new Login();
            ULogin.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Globals.CurrentUser = "Doctor";
            Hide();
            Login ULogin = new Login();
            ULogin.Show();
        }
    }
}
