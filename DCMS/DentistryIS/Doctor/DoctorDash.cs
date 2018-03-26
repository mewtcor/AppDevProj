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

namespace DentistryIS
{
    public partial class DoctorDash : Form
    {
        
        public DoctorDash()
        {
            
            InitializeComponent();
            timer1.Start();
            
        }
        private void DoctorDash_Load(object sender, EventArgs e)
        {
            lblCurUser.Text = Globals.CurrentUser;
            lblCurDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            //lblCurTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); //result 11:11:45 PM

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblCurTime.Text = dateTime.ToString("hh:mm:ss tt");    
        }
        private void viewProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DrDashClass frm = new DrDashClass();
            frm.InvDrProfile();
        }
            
        private void patientRecordsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DrDashClass frm = new DrDashClass();
            frm.InvDrPatients();
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrDashClass frm = new DrDashClass();
            frm.InvDrAppointments();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DrDashClass frm = new DrDashClass();
            frm.InvDrCPW();
        }

        private void logOffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login callLogin = new Login();
            callLogin.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrDashClass frm = new DrDashClass();
            frm.InvDrReports();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrDashClass frm = new DrDashClass();
            frm.InvDrPayment();
          
        }

  
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrDashClass frm = new DrDashClass();
            frm.InvDrAbout();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit system
            System.Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      
    }
}
