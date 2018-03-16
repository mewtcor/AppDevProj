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


namespace DentistryIS.Assistant
{
    public partial class PatientInfo : Form
    {
        //for image storing
        string fileneame;

        public PatientInfo()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DCMSdb"].ConnectionString;
        private SqlDataReader rdr;

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO Patient (Name, Age, Gender, Address, ContactNo, DOB, BloodGroup, HealthProblem, Image) Values (@Name, @Age, @Gender, @Address, @ContactNo, @DOB, @BloodGroup, @HealthProblem, @Image)", conn);

            cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
            cmd.Parameters.AddWithValue("@Age", AgeTextBox.Text);
            cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
            cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNoTextBox.Text);
            cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@BloodGroup", BloodGroupComboBox.Text);
            cmd.Parameters.AddWithValue("@HealthProblem", HealthProbTextBox.Text);
            cmd.Parameters.AddWithValue("@Image", ConvertImageToBinary(ImagePictureBox.Image));

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Patient Successfully Added!");
                ClearTB();
                ShowData();
            }

            conn.Close();
        }

        private void ClearTB()
        {
             NameTextBox.Text = " ";
             AgeTextBox.Text = " ";
            GenderComboBox.Text = " ";
            AddressTextBox.Text = " ";
            ContactNoTextBox.Text = " ";
            DOBDateTimePicker.Value = System.DateTime.Now;
            BloodGroupComboBox.Text = " ";
            HealthProbTextBox.Text = " ";

        }

        private void ShowData()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * from Patient WHERE Name LIKE @Name", conn);

            cmd.Parameters.AddWithValue("@Name", SearchTextBox.Text + "%");

            System.Data.DataTable dt = new System.Data.DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                PatientDataGridView.DataSource = dt;

            }
            else
            {
                
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private int PatientID;
        private void PatientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PatientDataGridView.Rows[e.RowIndex];

                PatientID = Convert.ToInt32(row.Cells["Patient_ID"].Value);
                labelID.Text = PatientID.ToString();
                NameTextBox.Text = row.Cells["Name"].Value.ToString();
                AgeTextBox.Text = row.Cells["Age"].Value.ToString();
                GenderComboBox.Text = row.Cells["Gender"].Value.ToString();
                AddressTextBox.Text = row.Cells["Address"].Value.ToString();
                ContactNoTextBox.Text = row.Cells["ContactNo"].Value.ToString();
                if ((row.Cells["DOB"].Value) == DBNull.Value)
                {
                    DOBDateTimePicker.Value = System.DateTime.Now;
                }
                else
                {
                    DOBDateTimePicker.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                }
                BloodGroupComboBox.Text = row.Cells["BloodGroup"].Value.ToString();
                HealthProbTextBox.Text = row.Cells["HealthProblem"].Value.ToString();
                if ((row.Cells["image"].Value) == DBNull.Value)
                {
                    ImagePictureBox.Image = null;
                    ImagePictureBox.Invalidate();
                }
                else
                {
                    MemoryStream ms = new MemoryStream((byte[])PatientDataGridView.CurrentRow.Cells["Image"].Value);
                    ImagePictureBox.Image = Image.FromStream(ms);
                }


            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            updatePatient();
        }

        private void updatePatient()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Update Patient SET Name=@Name, Age=@Age, Gender=@Gender, Address=@Address, ContactNo=@ContactNo, DOB=@DOB, BloodGroup=@BloodGroup, HealthProblem=@HealthProblem, Image=@Image WHERE Patient_ID=@PatientID", conn);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
            cmd.Parameters.AddWithValue("@Age", AgeTextBox.Text);
            cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
            cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNoTextBox.Text);
            cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@BloodGroup", BloodGroupComboBox.Text);
            cmd.Parameters.AddWithValue("@HealthProblem", HealthProbTextBox.Text);
            cmd.Parameters.AddWithValue("@Image", ConvertImageToBinary(ImagePictureBox.Image));


            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Patient ID: " + labelID.Text + " has been updated!");

                ClearTB();
                ShowData();
            }
            conn.Close();
        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog OpenFd = new OpenFileDialog() { Filter = "Images only. | *.jpg; *jpeg; *png; *.gif;", ValidateNames = true, Multiselect = false })
            {
                if (OpenFd.ShowDialog() == DialogResult.OK)
                {
                    fileneame = OpenFd.FileName;
                    ImagePictureBox.Image = Image.FromFile(fileneame);
                }
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();

            }
        }

        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
