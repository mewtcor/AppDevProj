using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS
{
    class DrDashClass
    {
        public void InvDrProfile()
        {
            DrProfile newDrProfile = new DrProfile();
            newDrProfile.StartPosition = FormStartPosition.CenterScreen;
            newDrProfile.MaximizeBox = false;
            newDrProfile.MinimizeBox = false;
            newDrProfile.FormBorderStyle = FormBorderStyle.FixedSingle;
            newDrProfile.Visible = false;
            newDrProfile.ShowDialog();
        }
        public void InvDrPatients()
        {
            Doctor.DrPatients newDrPatients = new Doctor.DrPatients();
            // Set the Parent Form of the Child window.
            newDrPatients.MdiParent = Application.OpenForms["DoctorDash"];
            // set DoctorProfile form settings
            newDrPatients.FormBorderStyle = FormBorderStyle.None;
            newDrPatients.ControlBox = false;
            newDrPatients.MaximizeBox = false;
            newDrPatients.MinimizeBox = false;
            newDrPatients.Dock = DockStyle.Fill;
            // Display the new form.
            newDrPatients.Show();
        }
        public void InvDrAppointments()
        {
            Doctor.DrAppointments newDrAppointments = new Doctor.DrAppointments();
            newDrAppointments.MdiParent = Application.OpenForms["DoctorDash"];
            newDrAppointments.FormBorderStyle = FormBorderStyle.None;
            newDrAppointments.ControlBox = false;
            newDrAppointments.MaximizeBox = false;
            newDrAppointments.MinimizeBox = false;
            newDrAppointments.Dock = DockStyle.Fill;
            newDrAppointments.Show();
        }
       public void InvDrCPW()
        {
            Doctor.DrCPW drCPW = new Doctor.DrCPW();
            drCPW.Visible = false;
            drCPW.StartPosition = FormStartPosition.CenterScreen;
            drCPW.MaximizeBox = false;
            drCPW.MinimizeBox = false;
            //showing form as modal
            drCPW.ShowDialog();
        }
        public void InvDrReports()
        {
            Doctor.DrReports newDrReports = new Doctor.DrReports();
            newDrReports.MdiParent = Application.OpenForms["DoctorDash"];
            newDrReports.FormBorderStyle = FormBorderStyle.None;
            newDrReports.ControlBox = false;
            newDrReports.MaximizeBox = false;
            newDrReports.MinimizeBox = false;
            newDrReports.Dock = DockStyle.Fill;
            newDrReports.Show();
        }
        public void InvDrPayment()
        {
            Doctor.DrPayment newdrPayment = new Doctor.DrPayment();
            newdrPayment.MdiParent = Application.OpenForms["DoctorDash"];
            newdrPayment.FormBorderStyle = FormBorderStyle.None;
            newdrPayment.ControlBox = false;
            newdrPayment.MaximizeBox = false;
            newdrPayment.MinimizeBox = false;
            newdrPayment.Dock = DockStyle.Fill;
            newdrPayment.Show();
        }
        public void InvDrAbout()
        {
            Doctor.DrAbout newDrAbout = new Doctor.DrAbout();
            newDrAbout.StartPosition = FormStartPosition.CenterScreen;
            newDrAbout.Visible = false;
            newDrAbout.MaximizeBox = false;
            newDrAbout.MinimizeBox = false;
            newDrAbout.FormBorderStyle = FormBorderStyle.None;
            //show form as modal
            newDrAbout.ShowDialog();
        }
    }
}
