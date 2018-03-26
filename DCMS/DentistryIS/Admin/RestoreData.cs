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
    public partial class RestoreData : Form
    {
        public RestoreData()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        string connStr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        private void btnBrowseLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.mdf";
            ofd.Title = "Database Restore";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestoreData.Text = ofd.FileName;
                txtRestoreData.Enabled = true;
            }
        }

        private void btnRestoreData_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            string database = conn.Database.ToString();
            try
            {
                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                string sql2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestoreData.Text + "'WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Database has been Restored");
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

        private void RestoreData_Load(object sender, EventArgs e)
        {

        }
    }
}
