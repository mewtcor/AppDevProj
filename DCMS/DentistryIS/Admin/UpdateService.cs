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
    public partial class UpdateService : Form
    {
        public UpdateService()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private SqlCommand cmd;
        string connStr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        private SqlDataReader rdr;

        private void showData()
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT * FROM Service", conn);

            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Registered Service yet");
            }
            conn.Close();
        }

        public void clearField()
        {
            txtServiceName.Text = "";
            txtAmount.Text = "";
        }
        private void UpdateService_Load(object sender, EventArgs e)
        {

        }

        public int ID;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("UPDATE Service SET Service_Name=@ServiceName, Amount=@Amount where ServiceId=@ServiceId", conn);

            cmd.Parameters.AddWithValue("@ServiceId", ID);
            cmd.Parameters.AddWithValue("@ServiceName", txtServiceName.Text);
            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Name: " + txtServiceName.Text + " has been updated");
                showData();
                clearField();
            }
            conn.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            ID = Convert.ToInt32(row.Cells["ServiceId"].Value);
            //lblID.Text = row.Cells["ServiceId"].Value.ToString();
            txtServiceName.Text = row.Cells["Service_Name"].Value.ToString();
            txtAmount.Text = row.Cells["Amount"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
