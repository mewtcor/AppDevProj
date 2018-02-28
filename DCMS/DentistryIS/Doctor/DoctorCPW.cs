using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS.Doctor
{
    public partial class DoctorCPW : Form
    {
        public DoctorCPW()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void DoctorCPW_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Globals.CurrentUser;
        }
    }
}
