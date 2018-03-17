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
    public partial class ViewDentist : Form
    {
        public ViewDentist()
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
                MessageBox.Show("No Registered Dentist yet");
            }
            conn.Close();
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
