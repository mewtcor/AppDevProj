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
    public partial class DoctorDash : Form
    {
        public DoctorDash()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adForm = new AdminDash();
            adForm.Show();
        }

        private void assistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssistantDash asDash = new AssistantDash();
            asDash.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorProfile newDoctorProfile = new DoctorProfile();
            // Set the Parent Form of the Child window.
            newDoctorProfile.MdiParent = this;
            // Maximize Form
            newDoctorProfile.WindowState = FormWindowState.Maximized;
            // Display the new form.
            newDoctorProfile.Show();
        }
    }
}
