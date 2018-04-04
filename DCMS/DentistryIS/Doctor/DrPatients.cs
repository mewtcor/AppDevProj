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
using System.IO;

namespace DentistryIS.Doctor
{
    public partial class DrPatients : Form
    {
        
        public DrPatients()
        {
            InitializeComponent();
            DisableButtons();
            btnEdit.Text = "Edit";
            btnAdd.Enabled = true;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close this form
            Close();
        }

        private void ShowAll()
        {
            //author: enzo
            //this method displays all data in grdpatient(gridview) when called
            DrPatientClass grid = new DrPatientClass();
            DataTable dt = grid.GetAll();

            if (dt == null)
            {
                grdPatients.Columns.Clear();
            }
            else
            {
                grdPatients.DataSource = dt;
            }
            grdPatients.CurrentCell = null;
            ArrangeGridColumns();
        }
        private void DisableButtons()
        {
            btnBrowse.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnPayment.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void ArrangeGridColumns()
        {
            grdPatients.Columns[0].Width = 80;
            grdPatients.Columns[1].Width = 200;
            grdPatients.Columns[2].Width = 75;
            grdPatients.Columns[3].Width = 80;

            for (int i = 4; i <= 9; i++)
            {
                grdPatients.Columns[i].Visible = false;
            }
        }
        private void ShowLike()
        {
            DrPatientClass grid = new DrPatientClass();
            DataTable dt = grid.SearchByName();

            if (dt == null)
            {
                grdPatients.Columns.Clear();
            }
            else
            {
                grdPatients.DataSource = dt;
            }
            grdPatients.CurrentCell = null;

        }
        private void ClearTextFields()
        {
            txtPID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtDOB.Text = "";
            txtBloodGroup.Text = "";
            txtHealth.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            grdPatients.CurrentCell = null;
            picProfile.Image = null;
        }
        private void DrPatients_Load(object sender, EventArgs e)
        {
            ShowAll();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ShowAll();
                ClearTextFields();
                DisableButtons();
                btnAdd.Enabled = true;
            }
            else
            {
                Globals.SearchedName = txtSearch.Text;
                ShowLike();
            }
        }
        public int ID;

        private void FillGrid(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdPatients.Rows[e.RowIndex];
                ID = Convert.ToInt32(row.Cells["Patient_ID"].Value);
                txtPID.Text = row.Cells["Patient_ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtContactNo.Text = row.Cells["ContactNo"].Value.ToString();
                txtDOB.Text = row.Cells["DOB"].Value.ToString();
                txtBloodGroup.Text = row.Cells["BloodGroup"].Value.ToString();
                txtHealth.Text = row.Cells["HealthProblem"].Value.ToString();
                if ((row.Cells["Image"].Value) == DBNull.Value)
                {
                    picProfile.Image = null;
                    picProfile.Invalidate();
                }
                else
                {
                    MemoryStream ms = new MemoryStream((byte[])grdPatients.CurrentRow.Cells["Image"].Value);
                    picProfile.Image = Image.FromStream(ms);
                }
            }
        }

        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillGrid(e);
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            Doctor.DrPayment newDrPayment = new Doctor.DrPayment(picProfile.Image);
            Globals.CurrentPatientID = txtPID.Text;
            Globals.CurrentPatient = txtName.Text;
            newDrPayment.Show();
            this.Hide();
            newDrPayment.MdiParent = this.ParentForm;
            newDrPayment.FormBorderStyle = FormBorderStyle.None;
            newDrPayment.ControlBox = false;
            newDrPayment.MaximizeBox = false;
            newDrPayment.MinimizeBox = false;
            newDrPayment.Dock = DockStyle.Fill;

        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {
            DisableButtons();
            if (txtPID.Text == "")
            {
                return;
            }
            else
            {
                btnPayment.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ClearTextFields();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picProfile.Image = new Bitmap(open.FileName);
                // image file path  
                //curfolder.Text = open.FileName;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                setEdit();
                btnEdit.Text = "Cancel";
                btnPayment.Enabled = false;
                btnSave.Enabled = true;
                btnBrowse.Enabled = true;
            }
            else
            {
                if (txtPID.Text == "")
                {
                    btnEdit.Text = "Edit";
                    btnEdit.Enabled = false;
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnBrowse.Enabled = false;
                    btnDelete.Enabled = false;
                    DisableTexts();
                }
                else
                {
                    DisableTexts();
                    btnEdit.Text = "Edit";
                    btnSave.Enabled = false;
                    btnPayment.Enabled = true;
                    btnBrowse.Enabled = false;

                }
            }
        }
        private void setEdit()
        {
            txtName.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtGender.ReadOnly = false;
            txtDOB.ReadOnly = false;
            txtBloodGroup.ReadOnly = false;
            txtHealth.ReadOnly = false;
            txtContactNo.ReadOnly = false;
            txtAddress.ReadOnly = false;

        }
        private void DisableTexts()
        {
            txtName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtDOB.ReadOnly = true;
            txtBloodGroup.ReadOnly = true;
            txtHealth.ReadOnly = true;
            txtContactNo.ReadOnly = true;
            txtAddress.ReadOnly = true;

        }
        private void AddPatient()
        {
            int pID = ID;
            string name = txtName.Text;
            string age = txtAge.Text;
            string address = txtAddress.Text;
            string gender = txtGender.Text;
            int contactNo = Convert.ToInt32(txtContactNo.Text);
            string dob = txtDOB.Text;
            DateTime date = Convert.ToDateTime(txtDOB.Text);
            string bloodGroup = txtBloodGroup.Text;
            string healthProblem = txtHealth.Text;
            Image image = picProfile.Image;
            DrPatientClass pClass = new DrPatientClass();
            pClass.UpdatePatient(pID, name, age, address, gender, contactNo, dob, bloodGroup, healthProblem, image);
        }
        private void UpdatePatient()
        {
            int pID = ID;
            string name = txtName.Text;
            string age = txtAge.Text;
            string address = txtAddress.Text;
            string gender = txtGender.Text;
            int contactNo = Convert.ToInt32(txtContactNo.Text);
            string dob = txtDOB.Text;
            DateTime date = Convert.ToDateTime(txtDOB.Text);
            string bloodGroup = txtBloodGroup.Text;
            string healthProblem = txtHealth.Text;
            Image image = picProfile.Image;
            DrPatientClass pClass = new DrPatientClass();
            pClass.UpdatePatient(pID, name, age, address, gender, contactNo, dob, bloodGroup, healthProblem, image);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtGender.Text == "" || txtDOB.Text == "" || txtBloodGroup.Text == "" || txtHealth.Text == "" || txtContactNo.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Textfields cannot be blank!");
                return;
            }
            else
            {
                if (txtPID.Text == "")
                {
                    AddPatient();
                    //normalView();
                    btnEdit.Text = "Edit";
                    ClearTextFields();
                    DisableTexts();
                    btnPayment.Enabled = true;
                    btnEdit.Enabled = true;
                    ShowAll();
                }

                else
                {
                    UpdatePatient();
                    //normalView();
                    btnEdit.Text = "Edit";
                    ClearTextFields();
                    DisableTexts();
                    ShowAll();
                    btnPayment.Enabled = false;
                    btnEdit.Enabled = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = false;
                }
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            ClearTextFields();
            setEdit();
            btnEdit.Text = "Cancel";
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
            btnBrowse.Enabled = true;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DrPatientClass del = new DrPatientClass();
            string pid = txtPID.Text;
            del.DelProc(pid);
            //normalView();
            ClearTextFields();
            DisableTexts();
            ShowAll();
            btnPayment.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtContactNo.Text != "")
            {
                int cno;
                if (int.TryParse(txtContactNo.Text, out cno))
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Not a valid format, please type numbers only!");
                    txtContactNo.Text = "";
                    txtContactNo.Focus();
                }
                e.Cancel = true;
            }
            else
            {
                return;
            }
        }
    }
}
