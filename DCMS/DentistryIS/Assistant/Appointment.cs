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
            ShowAppointmentToday();
            AppointmentDatePicker.Value = System.DateTime.Now;
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
            cmd = new SqlCommand("SELECT * from Appointment WHERE Patient_Name LIKE @Name AND Cancelled=@Cancelled AND Date>=@Date", conn);

            cmd.Parameters.AddWithValue("@Name", ViewAppointmentTextBox.Text + "%");
            cmd.Parameters.AddWithValue("@Cancelled", false);
            cmd.Parameters.AddWithValue("@Date", DateTime.Today.Date);

            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("No data in table");
            }

        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO Appointment (PatientID, Patient_Name, Date, Time, Service, Dentist, Note) Values (@PatientID, @Patient_Name, @Date, @Time, @Service, @Dentist, @Note)", conn);

            cmd.Parameters.AddWithValue("@PatientID", PatientIDTextBox.Text);
            cmd.Parameters.AddWithValue("@Patient_Name", PatientNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Date", AppointmentDatePicker.Value);
            cmd.Parameters.AddWithValue("@Time", AppointmentTimeComboBox.Text);
            cmd.Parameters.AddWithValue("@Service", ServiceComboBox.Text);
            cmd.Parameters.AddWithValue("@Dentist", DentistComboBox.Text);
            cmd.Parameters.AddWithValue("@Note", NoteTextBox.Text);


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
            NoteTextBox.Text = " ";
            DentistComboBox.Text = " ";
            ServiceComboBox.Text = " ";
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
            catch (Exception)
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
            //fillout Dentist combo box
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
            catch (Exception)
            {
                MessageBox.Show("error in fill combo dentist");
            }
            conn.Close();


            //fillout Service combo box
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Service", conn);

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string dName = rdr["Service_Name"].ToString();
                    ServiceComboBox.Items.Add(dName);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error in fill combo service");
            }
            conn.Close();

            // fillout combo box time
            DateTime time = DateTime.Today;
            for (DateTime _time = time.AddHours(9); _time < time.AddHours(18); _time = _time.AddMinutes(30)) //from 9h to 17h hours
            {
                AppointmentTimeComboBox.Items.Add(_time.ToShortTimeString());
            }
        }



        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            EditAppointment();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DentistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int PatientID;
        private int AppointmentID;
        private void AppointmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AppointmentDataGridView.Rows[e.RowIndex];

                if (row.Cells["AppointmentID"].Value == DBNull.Value || row.Cells["PatientID"].Value == DBNull.Value)
                {
                    PatientIDTextBox.Text = " ";
                    AppointmentIDTextBox.Text = " ";
                }
                else
                {
                    AppointmentID = Convert.ToInt32(row.Cells["AppointmentID"].Value);
                    AppointmentIDTextBox.Text = AppointmentID.ToString();
                    PatientID = Convert.ToInt32(row.Cells["PatientID"].Value);
                    PatientIDTextBox.Text = PatientID.ToString();
                }

                PatientNameTextBox.Text = row.Cells["Patient_Name"].Value.ToString();
                NoteTextBox.Text = row.Cells["Note"].Value.ToString();
                ServiceComboBox.Text = row.Cells["Service"].Value.ToString();
                DentistComboBox.Text = row.Cells["Dentist"].Value.ToString();
                if ((row.Cells["Date"].Value) == DBNull.Value)
                {
                    AppointmentDatePicker.Value = System.DateTime.Now;
                }
                else
                {
                    AppointmentDatePicker.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                }
                AppointmentTimeComboBox.Text = row.Cells["Time"].Value.ToString();

            }
        }

        void EditAppointment()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Update Appointment SET PatientID=@PatientID, Patient_Name=@Patient_Name, Date=@Date, Time=@Time, Service=@Service, Dentist=@Dentist, Note=@Note WHERE AppointmentID=@AppointmentID", conn);

            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentIDTextBox.Text);
            cmd.Parameters.AddWithValue("@PatientID", PatientIDTextBox.Text);
            cmd.Parameters.AddWithValue("@Patient_Name", PatientNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Date", AppointmentDatePicker.Value);
            cmd.Parameters.AddWithValue("@Time", AppointmentTimeComboBox.Text);
            cmd.Parameters.AddWithValue("@Service", ServiceComboBox.Text);
            cmd.Parameters.AddWithValue("@Dentist", DentistComboBox.Text);
            cmd.Parameters.AddWithValue("@Note", NoteTextBox.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Appointment ID: " + AppointmentIDTextBox.Text + " has been updated!");

                ClearTB();
                ShowAppointmentData();
            }
            conn.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTB();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if(AppointmentIDTextBox.Text==" ")
            {
                MessageBox.Show("Please select appointment to cancel");
            }
            else
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("Update Appointment SET Cancelled=@Cancelled WHERE AppointmentID=@AppointmentID", conn);

                cmd.Parameters.AddWithValue("@AppointmentID", AppointmentIDTextBox.Text);
                cmd.Parameters.AddWithValue("@Cancelled", true);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Appointment ID: " + AppointmentIDTextBox.Text + " has been Cancelled!");

                    ClearTB();
                    ShowAppointmentData();
                }
                conn.Close();
            }
        }

        void ShowAppointmentToday()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Appointment WHERE Cancelled=@Cancelled AND Date=@Date", conn);

            cmd.Parameters.AddWithValue("@Cancelled", false);
            cmd.Parameters.AddWithValue("@Date", DateTime.Today.Date);

            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("No data in table");
            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
