using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DentistryIS.Doctor
{
    public partial class DrCPW : Form
    {
        
        public DrCPW()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoctorCPW_Load(object sender, EventArgs e)
        {
            lblName.Text = Globals.CurrentUser;
            btnSave.Enabled = false;
            txtNPW.Enabled = false;
            txtReNPW.Enabled = false;
            
        }
        private void btnSaveState()
        {
            if (txtNPW.Text == "" || txtReNPW.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void txtNPW_TextChanged(object sender, EventArgs e)
        {
            btnSaveState();
        }

        private void txtReNPW_TextChanged(object sender, EventArgs e)
        {
            btnSaveState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNPW.Text == txtReNPW.Text)
            {
                saveUpdate();
                txtNPW.Text = "";
                txtReNPW.Text = "";
                btnSave.Enabled = false;
                txtNPW.Enabled = false;
                txtReNPW.Enabled = false;
                txtOPW.Enabled = true;
                txtOPW.Focus();
                btnVerify.Enabled = true;
            }
            else
            {
                MessageBox.Show("Password does not match!");
                txtNPW.Text = "";
                txtReNPW.Text = "";
                txtNPW.Focus();
            }
        }
        private void saveUpdate()
        {
            string newPword = txtNPW.Text;
            string name = lblName.Text;
            CPWClass cpword = new CPWClass();

            cpword.UpdateRec(newPword, name);
            
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            CPWClass cpword = new CPWClass();
            string name = lblName.Text;
            string oldpw = txtOPW.Text;
            
            bool answ = cpword.DoesUsrExist(name, oldpw);
            if (answ == true)
            {
                VerifyUserGranted();
            }
            else
            {
                VerifyUserFailed();
            }
        }
        
        private void VerifyUserGranted()
        {
            MessageBox.Show("Awesome!");
            btnSave.Enabled = true;
            txtNPW.Enabled = true;
            txtReNPW.Enabled = true;
            txtOPW.Text = "";
            txtOPW.Enabled = false;
            txtNPW.Focus();
            btnVerify.Enabled = false;

        }
        private void VerifyUserFailed()
        {
            txtOPW.Text = "";
            txtOPW.Focus();
        }
    }
}
