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

namespace DentistryIS.Assistant
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            FillCombo();
            AutoCompleteText();
            //ShowAppointmentData();
        }

        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DCMSdb"].ConnectionString;
        private SqlDataReader rdr;

        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewAppointmentTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowAppointmentData();
        }

        private void ShowAppointmentData()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Appointment WHERE Patient_Name LIKE @Name", conn);

            cmd.Parameters.AddWithValue("@Name", ViewAppointmentTextBox.Text + "%");

            System.Data.DataTable dt = new System.Data.DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                AppointmentDataGridView.DataSource = dt;

            }
            else
            {

            }
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO Appointment (PatientID, Patient_Name, Date, Time, Service, Dentist ) Values (@PatientID, @Patient_Name, @Date, @Time, @Service, @Dentist)", conn);

            cmd.Parameters.AddWithValue("@PatientID", PatientIDTextBox.Text);
            cmd.Parameters.AddWithValue("@Patient_Name", PatientNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Date", AppointmentDatePicker.Value);
            cmd.Parameters.AddWithValue("@Time", AppointmentTimeComboBox.Text);
            cmd.Parameters.AddWithValue("@Service", ServiceTextBox.Text);
            cmd.Parameters.AddWithValue("@Dentist", DentistComboBox.Text);
            

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Appointment Successfully Added!");
                ClearTB();
                ShowAppointmentData();
            }

            conn.Close();
        }

        private void ClearTB()
        {
            AppointmentIDTextBox.Text = " ";
            PatientIDTextBox.Text = " ";
            PatientNameTextBox.Text = " ";
            AppointmentDatePicker.Value = System.DateTime.Now;
            AppointmentTimeComboBox.Text = " ";
            ServiceTextBox.Text = " ";
            DentistComboBox.Text = " ";
        }

      


        void AutoCompleteText()
        {
            //will complete and the patient name textbox with data from DB
            PatientNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PatientNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection PatientNamecoll = new AutoCompleteStringCollection();

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Patient", conn);

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string pName = rdr["Name"].ToString();
                    PatientNamecoll.Add(pName);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }
                
            conn.Close();

            PatientNameTextBox.AutoCompleteCustomSource = PatientNamecoll;

        }
        private void PatientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Patient WHERE Name = '" + PatientNameTextBox.Text + "'", conn);


            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string PatientID = rdr["Patient_ID"].ToString();
                    PatientIDTextBox.Text = PatientID;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error in reading database");
            }
            conn.Close();
        }

        void FillCombo()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Dentist", conn);

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string dName = rdr["Name"].ToString();
                    DentistComboBox.Items.Add(dName);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("error in fill combo");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
        }
    }
}
