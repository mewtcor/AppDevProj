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

namespace DentistryIS.Doctor
{
    public partial class DrAppointments : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        private SqlDataReader rdr;

        public DrAppointments()
        {
            InitializeComponent();
            FillCombo();
            AutoCompleteText();
            //ShowAppointmentData();
           
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ViewAppointmentTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowAppointmentData();
        }
        private void ShowAppointmentData()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Appointment WHERE Patient_Name LIKE @Name AND Dentist=@Dentist", conn);

            cmd.Parameters.AddWithValue("@Name", ViewAppointmentTextBox.Text + "%");
            cmd.Parameters.AddWithValue("@Dentist", Globals.CurrentUser);
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

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
        }

        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            EditAppointment();
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
                MessageBox.Show("Appointment for patient " + PatientNameTextBox.Text + " has been updated!");

                ClearTB();
                ShowAppointmentData();
            }
            conn.Close();
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
                disableButtons();
                btnClose.Enabled = true;
                btnEdit.Enabled = true;
                btnClear.Enabled = true;
                btnClear.Text = "Cancel";
            }
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            
        }


        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            AppointmentDataGridView.Columns.Clear();
            Globals.TempDate = dtpDate.Value;
            ShowByDate();            
        }
        private void ShowByDate()
        {
            DrAppointmentClass grid = new DrAppointmentClass();
            DataTable dt = grid.Get();
            
            if (dt == null)
            {
                AppointmentDataGridView.Columns.Clear();
            }
            else
            {
                AppointmentDataGridView.DataSource = dt;
            }
        }
        
        private void ShowAll()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Appointment WHERE Dentist = '" + Globals.CurrentUser + "'", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                dt.Load(rdr);
                AppointmentDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data to show");
            }
            conn.Close();
            AppointmentDataGridView.CurrentCell = null;

        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            AppointmentDataGridView.Columns.Clear();
            DrAppointmentClass grid = new DrAppointmentClass();
            DataTable dt = grid.GetAll();

            if (dt == null)
            {
                AppointmentDataGridView.Columns.Clear();
            }
            else
            {
                AppointmentDataGridView.DataSource = dt;
            }
        }

        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DrAppointments_Load(object sender, EventArgs e)
        {
            disableButtons();
            disableTextboxes();
            btnClose.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void DrAppointments_Shown(object sender, EventArgs e)
        {
            AppointmentDatePicker.Value = DateTime.Now;
            dtpDate.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnClear.Text == "Clear")
            {
                ClearTB();
                disableButtons();
                btnClose.Enabled = true;
                btnAdd.Enabled = true;
            }
            else if (btnClear.Text =="Cancel")
            {
                ClearTB();
                disableButtons();
                btnAdd.Enabled = true;
                btnClose.Enabled = true;
                disableTextboxes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            disableButtons();
            btnSave.Text = "Update";
            btnClear.Text = "Cancel";
            btnClose.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            enableTextboxes();
            
           // EditAppointment();

        }
        private void disableButtons()
        {
            btnClear.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
        }
        private void enableTextboxes()
        {
            PatientNameTextBox.ReadOnly = false;
            AppointmentDatePicker.Enabled = true;
            AppointmentTimeComboBox.Enabled = true;
            ServiceComboBox.Enabled = true;
            DentistComboBox.Enabled = true;
            NoteTextBox.ReadOnly = false;
        }
        private void disableTextboxes()
        {
            PatientNameTextBox.ReadOnly = true;
            AppointmentDatePicker.Enabled = false;
            AppointmentTimeComboBox.Enabled = false;
            ServiceComboBox.Enabled = false;
            DentistComboBox.Enabled = false;
            NoteTextBox.ReadOnly = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            disableButtons();
            btnClose.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Text = "Save";
            btnClear.Text = "Cancel";
            btnClear.Enabled = true;
            enableTextboxes();
        }
        
        private void SaveNew()
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
                //ShowAppointmentData();
                ShowByDate();
            }

            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (PatientNameTextBox.Text == "" || AppointmentTimeComboBox.Text == "" || ServiceComboBox.Text == "" || DentistComboBox.Text == "")
                {
                    MessageBox.Show("Please check for blank fields.");
                }
                else
                {
                    SaveNew();
                    ShowByDate();
                }
            }
            else if (btnSave.Text == "Update") ;
            {
                if (PatientNameTextBox.Text == "" || AppointmentTimeComboBox.Text == "" || ServiceComboBox.Text == "" || DentistComboBox.Text == "")
                {
                    MessageBox.Show("Please check for blank fields.");
                }
                else
                {
                    EditAppointment();
                    ShowByDate();
                    disableTextboxes();
                    disableButtons();
                    btnAdd.Enabled = true;
                    btnClose.Enabled = true;
                }
            }
        }
    }
}
