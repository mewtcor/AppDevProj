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
    public partial class AssistantDash : Form
    {
        public AssistantDash()
        {
            InitializeComponent();
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
            newAppointment.WindowState = FormWindowState.Maximized;
            // Display the new form.
            newAppointment.Show();
        }
    }
}
