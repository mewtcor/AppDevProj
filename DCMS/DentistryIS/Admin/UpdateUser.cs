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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private SqlCommand cmd;
        string connStr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        private SqlDataReader rdr;

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }

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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("UPDATE Users SET Username=@Username, Password=@Password, UAccess=@UAccess, Name=@Name, Contact=@Contact, Address=@Address where Id=@Id", conn);

            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            cmd.Parameters.AddWithValue("@UAccess", comboBoxUA.SelectedItem);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Username: " + txtUsername.Text + " has been updated");
                showData();
                clearField();
            }
            conn.Close();
        }

        public int ID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
