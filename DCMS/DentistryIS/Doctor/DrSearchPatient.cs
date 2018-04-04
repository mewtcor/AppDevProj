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
using System.IO;

namespace DentistryIS.Doctor
{
    public partial class DrSearchPatient : Form
    {
        public DrSearchPatient()
        {
            InitializeComponent();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowAll()
        {
            DrSearchPatientClass frm = new DrSearchPatientClass();
            DataTable dt = frm.GetGridItems();
            if (dt == null)
            {
                grdPatients.CurrentCell = null;
            }
            else
            {
                grdPatients.DataSource = dt;
                ArrangeGridColumns();

            }
        }
        private void ArrangeGridColumns()
        {
            grdPatients.Columns[0].Visible = false;
            grdPatients.Columns[1].Width = 160;


            for (int i = 2; i <= 9; i++)
            {
                grdPatients.Columns[i].Visible = false;
            }
        }
        private void ShowLike()
        {
            string SearchName = txtSearch.Text;
            DrSearchPatientClass frm = new DrSearchPatientClass();

            DataTable dt = frm.SearchByName(SearchName);
            if (dt == null)
            {
                grdPatients.CurrentCell = null;
            }
            else
            {
                grdPatients.DataSource = dt;
                ArrangeGridColumns();

            }
        }

        private void ClearTextFields()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtContact.Text = "";
        }

        private void DrSearchPatient_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ShowAll();
                ClearTextFields();
            }
            else
            {
                
                ShowLike();
            }
        }

        public int ID;
        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdPatients.Rows[e.RowIndex];

                ID = Convert.ToInt32(row.Cells["Patient_ID"].Value);
                txtPID.Text = row.Cells["Patient_ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtContact.Text = row.Cells["ContactNo"].Value.ToString();
                if ((row.Cells["Image"].Value) == DBNull.Value)
                {
                    picProfile.Image = null;
                    picProfile.Invalidate();
                }
                else
                {
                    MemoryStream ms = new MemoryStream((byte[])grdPatients.CurrentRow.Cells["Image"].Value);
                    picProfile.Image = Image.FromStream(ms);

                }
            }
        }
        public static string PID;
        public static string PName;
        public static string PDate;
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
           
            PID = txtPID.Text;
            PName = txtName.Text;
            PDate = DateTime.Now.ToString("dd MMMM yyyy");

            this.Close();
        }
        public Image SelectedImage
        {
            get { return picProfile.Image; }
        }
    }
}
