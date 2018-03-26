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
    public partial class AssistantDash : Form
    {
        
        public AssistantDash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adDash = new AdminDash();
            adDash.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDash drDash = new DoctorDash();
            drDash.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void patientRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assistant.PatientInfo newAssistantPatientInfo = new Assistant.PatientInfo();
            // Set the Parent Form of the Child window.
            newAssistantPatientInfo.MdiParent = this;
            // Maximize Form
            newAssistantPatientInfo.WindowState = FormWindowState.Maximized;
            // Display the new form.
            newAssistantPatientInfo.Show();
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assistant.Appointment newAppointment = new Assistant.Appointment();
            // Set the Parent Form of the Child window.
            newAppointment.MdiParent = this;
            // Maximize Form
            //newAppointment.WindowState = FormWindowState.Maximized;
            // Display the new form.
            newAppointment.FormBorderStyle = FormBorderStyle.None;
            newAppointment.ControlBox = false;
            newAppointment.MaximizeBox = false;
            newAppointment.MinimizeBox = false;
            newAppointment.Dock = DockStyle.Fill;
            newAppointment.Show();
        }

        private void AssistantDash_Load(object sender, EventArgs e)
        {
            lblCurUser.Text = Globals.CurrentUser;
            lblCurDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor.DrPayment newdrPayment = new Doctor.DrPayment();
            newdrPayment.MdiParent = this;
            newdrPayment.FormBorderStyle = FormBorderStyle.None;
            newdrPayment.ControlBox = false;
            newdrPayment.MaximizeBox = false;
            newdrPayment.MinimizeBox = false;
            newdrPayment.Dock = DockStyle.Fill;
            newdrPayment.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor.DrReports newDrReports = new Doctor.DrReports();
            newDrReports.MdiParent = this;
            newDrReports.FormBorderStyle = FormBorderStyle.None;
            newDrReports.ControlBox = false;
            newDrReports.MaximizeBox = false;
            newDrReports.MinimizeBox = false;
            newDrReports.Dock = DockStyle.Fill;
            newDrReports.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrProfile newDrProfile = new DrProfile();

            // Display the new form.
            newDrProfile.StartPosition = FormStartPosition.CenterScreen;
            newDrProfile.MaximizeBox = false;
            newDrProfile.MinimizeBox = false;
            newDrProfile.FormBorderStyle = FormBorderStyle.Fixed3D;
            newDrProfile.Visible = false;
            newDrProfile.BackColor = Color.AliceBlue;
            newDrProfile.ShowDialog();
        }

        private void switchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login callLogin = new Login();
            callLogin.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit system
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblCurTime.Text = dateTime.ToString("hh:mm:ss tt");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor.DrAbout newDrAbout = new Doctor.DrAbout();
            newDrAbout.StartPosition = FormStartPosition.CenterScreen;
            newDrAbout.Visible = false;
            newDrAbout.MaximizeBox = false;
            newDrAbout.MinimizeBox = false;
            newDrAbout.FormBorderStyle = FormBorderStyle.None;
            newDrAbout.BackColor = Color.AliceBlue;
            //show form as modal
            newDrAbout.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor.DrCPW drCPW = new Doctor.DrCPW();
            drCPW.Visible = false;
            drCPW.StartPosition = FormStartPosition.CenterScreen;
            drCPW.MaximizeBox = false;
            drCPW.MinimizeBox = false;
            drCPW.FormBorderStyle = FormBorderStyle.Fixed3D;
            drCPW.BackColor = Color.AliceBlue;
            //showing form as modal
            drCPW.ShowDialog();
        }
    }
}
