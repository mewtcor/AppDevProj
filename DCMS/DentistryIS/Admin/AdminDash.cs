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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            lblCurUser.Text = Globals.CurrentUser;
            lblCurDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

       

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser form = new ViewUser();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser form = new UpdateUser();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;       
            form.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser form = new DeleteUser();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
        }

        private void addProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProfile form = new AddProfile();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
            
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProfile form = new UpdateProfile();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
            
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddService form = new AddService();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
            
        }

        private void updateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateService form = new UpdateService();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
            
        }

        private void backUpDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUpData form = new BackUpData();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
            
        }

        private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreData form = new RestoreData();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
           
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDentist form = new ViewDentist();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.ShowDialog();
           
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblCurTime.Text = dateTime.ToString("hh:mm:ss tt");
        }
    }
}
