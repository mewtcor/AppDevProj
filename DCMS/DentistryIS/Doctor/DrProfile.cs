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
    public partial class DrProfile : Form
    {
       

        public DrProfile()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();        }

        private void DoctorProfile_Load(object sender, EventArgs e)
        {
            DrProfileClass get = new DrProfileClass();
            txtName.Text = get.DatProfile().Item1;
            txtContactNo.Text = get.DatProfile().Item2;
            txtAddress.Text = get.DatProfile().Item3;
            txtUAccess.Text = get.DatProfile().Item4;
        }
    }
}
