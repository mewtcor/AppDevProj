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
using System.Speech.Synthesis;

namespace DentistryIS
{
    public partial class BackUpData : Form
    {
        public BackUpData()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maikel Suwisto\term2\application development\AppDevProj\DB\DCMSdb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtBackUp.Text = fbd.SelectedPath;
                btnBrowseLocation.Enabled = true;
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            conn.Open();
            string database = conn.Database.ToString();
            try
            {
                if (txtBackUp.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the backup file location");
                }
                else
                {
                    string q = "BACKUP DATABASE [" + database + "]TO DISK='" + txtBackUp.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH--mm--ss") + ".mdf'";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Backup!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
