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
    public partial class DrReports : Form
    {
        public DrReports()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
        }
        //db connection declarations
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        SqlDataReader rdr;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DrReports_Load(object sender, EventArgs e)
        {
        }
        private void ArrangeGridColumnsFinancial()
        {
            grdFinancial.Columns[4].Width = 210;

        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (tabReports.SelectedIndex == 0)
            {
                ShowAllFinancial();
                
            }
            else if (tabReports.SelectedIndex == 1)
            {
                ShowAllAppointments();
            }
        }
        private void ShowAllAppointments()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Appointment", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                dt.Load(rdr);
                grdAppointments.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data to show");
            }
            conn.Close();
            grdAppointments.CurrentCell = null;
        }
        private void ShowByDateFinancial()
        {
            if (tabReports.SelectedIndex == 0)
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("SELECT * FROM Bill WHERE Date='" + dtpDate.Value + "'", conn);
                DataTable dt = new DataTable();

                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                    grdFinancial.DataSource = dt;
                }
                else
                {
                    grdFinancial.Columns.Clear();
                    MessageBox.Show("No data to show");
                }
                conn.Close();
                grdFinancial.CurrentCell = null;
            }
        }
        private void ShowAllFinancial()
        {
            if (tabReports.SelectedIndex == 0)
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("SELECT * FROM Bill", conn);
                DataTable dt = new DataTable();

                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                    grdFinancial.DataSource = dt;
                }
                else
                {
                    grdFinancial.Columns.Clear();
                    MessageBox.Show("No data to show");
                    
                }
                conn.Close();
                grdFinancial.CurrentCell = null;
                ArrangeGridColumnsFinancial();
                ShowTotal();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (tabReports.SelectedIndex == 0)
            {
                ShowByDateFinancial();
                ShowTotal();
            }
            else if (tabReports.SelectedIndex == 1)
            {
                ShowByDateAppointments();
            }
        }
        private void ShowByDateAppointments()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM Appointment WHERE Date='" + dtpDate.Value + "'", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                dt.Load(rdr);
                grdAppointments.DataSource = dt;
            }
            else
            {
                grdAppointments.Columns.Clear();
                MessageBox.Show("No data to show");
            }
            conn.Close();
            grdAppointments.CurrentCell = null;
        }
        private void ShowTotal()
        {
            decimal total = 0;
            for (int i = 0; i < grdFinancial.Rows.Count; i++)
            {
                total += decimal.Parse(grdFinancial.Rows[i].Cells[6].Value.ToString());
                txtTotal.TextAlign = HorizontalAlignment.Right;
                txtRepTotal.Text = total.ToString("###,###.00");
                lblCount.Text = grdFinancial.Rows.Count.ToString();
            }
            
        }
        public int ID;
        private void FillGrid(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdFinancial.Rows[e.RowIndex];

            ID = Convert.ToInt32(row.Cells["Bill_ID"].Value);
            txtBillID.Text = ID.ToString();
            txtDentistID.Text = row.Cells["Dentist_ID"].Value.ToString();
            txtPatientID.Text = row.Cells["Patient_ID"].Value.ToString();
            txtDate.Text = row.Cells["Date"].Value.ToString();
            txtParticulars.Text = row.Cells["Service"].Value.ToString();
            txtTotal.Text = row.Cells["Bill_Total"].Value.ToString();
        }

        private void grdFinancial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillGrid(e);
        }

        private void tabReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabReports.SelectedIndex == 0)
            {
                ClearFields();
                ShowAllFinancial();
            }
            else if (tabReports.SelectedIndex == 1)
            {
                ClearFields();
                ShowAllAppointments();
            }
        }
        private void ClearFields()
        {
            txtBillID.Text = "";
            txtPatientID.Text = "";
            txtDentistID.Text = "";
            txtDate.Text = "";
            txtParticulars.Text = "";
            txtTotal.Text = "";
            lblCount.Text = "0";
            txtRepTotal.Text = "0";
            grdFinancial.Columns.Clear();
            grdAppointments.Columns.Clear();
            dtpDate.Value = DateTime.Now;
        }

        private int PatientID;
        private int AppointmentID;
        private void grdAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = grdAppointments.Rows[e.RowIndex];

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
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
