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
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDash drForm = new DoctorDash();
            drForm.Show();
        }

        private void assistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssistantDash asForm = new AssistantDash();
            asForm.Show();    
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser form = new ViewUser();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser form = new UpdateUser();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser form = new DeleteUser();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void addProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProfile form = new AddProfile();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProfile form = new UpdateProfile();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddService form = new AddService();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void updateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateService form = new UpdateService();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void backUpDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUpData form = new BackUpData();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreData form = new RestoreData();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDentist form = new ViewDentist();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }
    }
}
