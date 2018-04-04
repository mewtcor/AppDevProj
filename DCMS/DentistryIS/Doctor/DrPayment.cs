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
using System.Drawing.Printing;


namespace DentistryIS.Doctor
{
    public partial class DrPayment : Form
    {

       
        public DrPayment()
        {
            InitializeComponent();
            InitLvw();
        }
        public DrPayment(System.Drawing.Image i)
        {
            InitializeComponent();
            picProfPayment.Image = i;
            InitLvw();
        }
        private void FillDrCmb()
        {
            DrPaymentClass frmdat = new DrPaymentClass();
            DataTable dat = frmdat.DatFillDrCmb();
            if (dat != null)
            {
                cmbDr.ValueMember = dat.Columns[0].ToString();
                cmbDr.DataSource = dat;
            }
        }
        private void FillPartCmb()
        {
            DrPaymentClass frmdat = new DrPaymentClass();
            DataTable dat = frmdat.DatFillPartCmb();
            if (dat != null)
            {
                cmbPart.ValueMember = dat.Columns[0].ToString();
                cmbPart.DataSource = dat;
                cmbPart.SelectedIndex = -1;
                
            }
        }
        public String DrPaymentTempText;
        private void FillDrID()
        {
            string drName = cmbDr.Text;
            DrPaymentClass dat = new DrPaymentClass();
            txtDID.Text =  dat.DatDrID(drName);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            DrSearchPatient.PID = null;
            DrSearchPatient.PName = null;
            Globals.CurrentPatientID = null;
            Globals.CurrentPatient = null;
        }

        private void DrPayment_Load(object sender, EventArgs e)
        {
          
            txtPID.Text = Globals.CurrentPatientID;
            txtPName.Text = Globals.CurrentPatient;
            txtPDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            CurDrInfo();
        }
        private void CurDrInfo()
        {
            DrPaymentClass getdat = new DrPaymentClass();
            txtDID.Text = getdat.DatCurDrInfo().Item1;
            cmbDr.Text = getdat.DatCurDrInfo().Item2;
        }

        private void cmbDr_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDrID();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            Doctor.DrSearchPatient drnewSP = new Doctor.DrSearchPatient();
            drnewSP.Visible = false;
            drnewSP.StartPosition = FormStartPosition.CenterScreen;
            drnewSP.MaximizeBox = false;
            drnewSP.MinimizeBox = false;
            drnewSP.FormBorderStyle = FormBorderStyle.None;
            drnewSP.BackColor = Color.CornflowerBlue;
            //showing form as modal
            drnewSP.ShowDialog();
            txtPID.Text = Doctor.DrSearchPatient.PID;
            txtPName.Text = Doctor.DrSearchPatient.PName;
            txtPDate.Text = Doctor.DrSearchPatient.PDate;
            picProfPayment.Image = drnewSP.SelectedImage;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPart.Text == "" || txtAmount.Text =="")
            {
                MessageBox.Show("Particular and Amount fields cannot be blank!");
                txtAmount.Focus();
                return;
            }
            else
            {
                string amount = int.Parse(txtAmount.Text).ToString("###,###.00");
                string[] row = { cmbPart.Text, amount };
                var listViewItem = new ListViewItem(row);
                lvwParticulars.Items.Add(listViewItem);
                cmbPart.Text = "";
                txtAmount.Text = "";
            }
            getTotal();
        }
        private void InitLvw()
        {
            lvwParticulars.View = View.Details;
            // Add columns
            lvwParticulars.Columns.Add("Particular/s", 300, HorizontalAlignment.Left);
            lvwParticulars.Columns.Add("Amount");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Cannot create invoice without particulars/fees.");
                return;
            }
            else
            {
                getParticulars();
                SaveDat();
                setPreview();
                btnPrint.Enabled = false;
            }
        }
       public void PrintPage(object sender, PrintPageEventArgs e)
        {
            //string text = AllParticulars;
            // e.Graphics.DrawString(lvwParticulars.Items[i].SubItems[1].Text, new Font("Georgia", 35, FontStyle.Bold), Brushes.Black, 10, 10);
            
            {
                e.Graphics.DrawString("The Tooth Fairy", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, 320, 50);
                e.Graphics.DrawString("Auckland New Zealand", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 280, 80);
                e.Graphics.DrawString("_____________________________________________________________________", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 10, 90);
                e.Graphics.DrawString("Particular/s", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 100, 130);
                e.Graphics.DrawString("Amount", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 600, 130);
                e.Graphics.DrawString("_____________________________________________________________________", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 10, 150);

                e.Graphics.DrawString("_____________________________________________________________________", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 10, 1000);
                e.Graphics.DrawString("Total:", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 550, 1030);
                e.Graphics.DrawString("_____________________________________________________________________", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 10, 1060);

                int ctrPart = 180;
                int ctrAmt = 180;
                //listview Items
                for (int i = 0; i < lvwParticulars.Items.Count; i++)
                {
                    e.Graphics.DrawString(lvwParticulars.Items[i].SubItems[0].Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 100, ctrPart);
                    ctrPart = ctrPart + 30;
                    e.Graphics.DrawString(lvwParticulars.Items[i].SubItems[1].Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 600, ctrAmt);
                    ctrAmt = ctrAmt + 30;
                }
                e.Graphics.DrawString(txtTotal.Text, new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, 630, 1030);
            }

        }
        private void setPreview()
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);
            prtPayment.Document = printDocument1;
        }
        
        public void SaveDat()
        {
            DrPaymentClass dat = new DrPaymentClass();
            string did = txtDID.Text;
            string pid = txtPID.Text;
            string date = txtPDate.Text;
            string allp = AllParticulars;
            string ttotal = txtTotal.Text;
            dat.Save(did, pid, date, allp, ttotal);
             
        }
        private void clearFields()
        {
            txtPID.Text = "";
            txtPName.Text = "";
            txtTotal.Text = "";
            cmbPart.Text = "";
            cmbPart.Enabled = false;
            txtAmount.Enabled = false;
            lvwParticulars.Items.Clear();
            prtPayment.Document = null;
        }
        private void cmbPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPart.SelectedIndex == -1)
            {
                txtAmount.Text = "";
                return;
            }
            else
            {
                string servName = cmbPart.Text;
                DrPaymentClass dat = new DrPaymentClass();
                txtAmount.Text = dat.datServAmount(servName);
            }
        }

        public string AllParticulars;
        private void getParticulars()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < lvwParticulars.Items.Count; i++)
            {
                var combParticulars = new StringBuilder();

                builder.Append(lvwParticulars.Items[i].SubItems[0].Text).ToString();
                builder.Append(", ");
                
            }
            AllParticulars = builder.ToString();
            //MessageBox.Show(builder.ToString());
        }

        private void getTotal()
        {
            decimal total = 0;
            for (int i = 0; i < lvwParticulars.Items.Count; i++)
            {
                total += decimal.Parse(lvwParticulars.Items[i].SubItems[1].Text);
                txtTotal.TextAlign = HorizontalAlignment.Right;
                txtTotal.Text = total.ToString("###,###.00");
            }
            btnPrint.Enabled = true;
        }

        private void lvwParticulars_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {
            if (txtPID.Text == "")
            {
                cmbPart.Enabled = false;
                txtAmount.Enabled = false;
            }
            else
            {
                cmbPart.Enabled = true;
                txtAmount.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {
            FillDrCmb();
            FillPartCmb();

        }
    }
}
