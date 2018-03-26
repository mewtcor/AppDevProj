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
        //db connection declarations
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        SqlDataReader rdr;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ShowAll()
        {
            //author: enzo
            //this method displays all data in grdpatient(gridview) when called
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Patient", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                dt.Load(rdr);
                grdPatients.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data to show");
            }
            conn.Close();
            grdPatients.CurrentCell = null;
            ArrangeGridColumns();
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
            //author:enzo
            //this method displays all data that corresponds to the name in the search field (txtsearch)
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Patient WHERE Name LIKE @Name", conn);

            cmd.Parameters.AddWithValue("Name", txtSearch.Text + "%");
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                grdPatients.DataSource = dt;
            }

            conn.Close();
            grdPatients.CurrentCell = null;
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
