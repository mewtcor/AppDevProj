﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            AdminDash adForm = new AdminDash();
            adForm.Show();
        }
        private void AdminLogin()
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {
            //StartUp StartUpForm = new StartUp();
            //lblUser.Text = StartUpForm.LabelUser;
        }
    }
}
