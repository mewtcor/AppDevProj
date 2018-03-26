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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
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
            cmd = new SqlCommand("SELECT * FROM Users", conn);

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
                MessageBox.Show("No Registered users yet");
            }
            conn.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showData();
        }

        public int ID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            ID = Convert.ToInt32(row.Cells["Id"].Value);
            lblID.Text = row.Cells["Id"].Value.ToString();
            txtUsername.Text = row.Cells["Username"].Value.ToString();
            txtPass.Text = row.Cells["Password"].Value.ToString();
            comboBoxUA.Text = row.Cells["UAccess"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString(); ;
            txtContact.Text = row.Cells["Contact"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearField()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            comboBoxUA.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            lblID.Text = "";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("DELETE FROM Users where Id= '"+ ID +"'", conn);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Username: " + txtUsername.Text + " has been deleted");
                showData();
                clearField();
                
            }
            conn.Close();

        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}
