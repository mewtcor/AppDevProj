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
    public partial class AddUser : Form
    {
        public AddUser()
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

        public void clearField()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            comboBoxUA.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("INSERT INTO Users (Username, Password, UAccess, Name, Contact, Address) VALUES (@Username, @Password, @UAccess, @Name, @Contact, @Address)", conn);

            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            cmd.Parameters.AddWithValue("@UAccess", comboBoxUA.SelectedItem);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully Added!");
            }
            conn.Close();
            showData();
            clearField();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            showData();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
