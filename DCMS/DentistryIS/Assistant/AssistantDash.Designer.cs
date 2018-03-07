namespace DentistryIS
{
    partial class AssistantDash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssistantDash));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.patientProfileToolStripMenuItem,
            this.patientRecordToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.switchAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(148, 389);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileToolStripMenuItem.Image")));
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // patientProfileToolStripMenuItem
            // 
            this.patientProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientProfileToolStripMenuItem.Image")));
            this.patientProfileToolStripMenuItem.Name = "patientProfileToolStripMenuItem";
            this.patientProfileToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.patientProfileToolStripMenuItem.Text = "Patient Profile";
            // 
            // patientRecordToolStripMenuItem
            // 
            this.patientRecordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientRecordToolStripMenuItem.Image")));
            this.patientRecordToolStripMenuItem.Name = "patientRecordToolStripMenuItem";
            this.patientRecordToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.patientRecordToolStripMenuItem.Text = "Patient Record";
            this.patientRecordToolStripMenuItem.Click += new System.EventHandler(this.patientRecordToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentsToolStripMenuItem.Image")));
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentsToolStripMenuItem.Image")));
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // switchAccountToolStripMenuItem
            // 
            this.switchAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.doctorToolStripMenuItem});
            this.switchAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("switchAccountToolStripMenuItem.Image")));
            this.switchAccountToolStripMenuItem.Name = "switchAccountToolStripMenuItem";
            this.switchAccountToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.switchAccountToolStripMenuItem.Text = "Switch Account";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // AssistantDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssistantDash";
            this.Text = "AssistantDash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
    }
}