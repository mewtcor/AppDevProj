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
    public partial class AddProfile : Form
    {
        public AddProfile()
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
            cmd = new SqlCommand("SELECT * FROM Dentist", conn);

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
                MessageBox.Show("No Dentist Profile yet");
            }
            conn.Close();
        }

        public void clearField()
        {
            txtName.Text = "";
            txtAge.Text = "";
            comboBoxGender.Text = "";
            txtBloodGroup.Text = "";
            dateTimePicker1.Text = "";
            txtSpeciality.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("INSERT INTO Dentist (Name, Age, Gender, DOB, BloodGroup, Specialty) VALUES (@Name, @Age, @Gender, @DOB, @BloodGroup, @Specialty)", conn);

            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBoxGender.SelectedItem);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.ToString("M/dd/yyyy"));
            cmd.Parameters.AddWithValue("@BloodGroup", txtBloodGroup.Text);
            cmd.Parameters.AddWithValue("@Specialty", txtSpeciality.Text);

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
    }
}
