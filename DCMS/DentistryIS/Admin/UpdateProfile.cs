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
    public partial class UpdateProfile : Form
    {
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private SqlCommand cmd;
        string connStr = ConfigurationManager.ConnectionStrings["DCMSdb"].ConnectionString;
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showData();
        }

        public int ID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            ID = Convert.ToInt32(row.Cells["DentistId"].Value);
            lblID.Text = row.Cells["DentistId"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtAge.Text = row.Cells["Age"].Value.ToString();
            comboBoxGender.Text = row.Cells["Gender"].Value.ToString();
            dateTimePicker1.Text = row.Cells["DOB"].Value.ToString(); ;
            txtBloodGroup.Text = row.Cells["BloodGroup"].Value.ToString();
            txtSpeciality.Text = row.Cells["Speciality"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("UPDATE Dentist SET Name=@Name, Age=@Age, Gender=@Gender, DOB=@DOB, BloodGroup=@BloodGroup, Speciality=@Speciality where DentistId=@DentistId", conn);

            cmd.Parameters.AddWithValue("@DentistId", ID);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBoxGender.SelectedItem);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.ToString("M/dd/yyyy"));
            cmd.Parameters.AddWithValue("@BloodGroup", txtBloodGroup.Text);
            cmd.Parameters.AddWithValue("@Speciality", txtSpeciality.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Name: " + txtName.Text + " has been updated");
                showData();
                clearField();
            }
            conn.Close();
        }
    }
}
