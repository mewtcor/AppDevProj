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
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        public DrProfile()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();        }

        private void DoctorProfile_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.MinimizeBox = false;
            //this.MaximizeBox = false;
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select * from Users where Username='" + Globals.CurrentUserName + "'", conn);

            conn.Open();
            var rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txtName.Text = rd["Name"].ToString();
                    txtContactNo.Text = rd["Contact"].ToString();
                    txtAddress.Text = rd["Address"].ToString();
                    txtUAccess.Text = rd["UAccess"].ToString();
                }
            }
        }
    }
}
