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
    public partial class AddService : Form
    {
        public AddService()
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("INSERT INTO Service (Service_Name, Amount) VALUES (@ServiceName, @Amount)", conn);

            cmd.Parameters.AddWithValue("@ServiceName", txtServiceName.Text);
            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
           
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("New Service has been Added!");
            }
            conn.Close();
            showData();
            clearField();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }
    }
}
