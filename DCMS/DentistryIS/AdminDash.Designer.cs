namespace DentistryIS
{
    partial class AdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageReportsToolStripMenuItem,
            this.switchAccountsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(239, 704);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageUsersToolStripMenuItem.Image")));
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // manageReportsToolStripMenuItem
            // 
            this.manageReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageReportsToolStripMenuItem.Image")));
            this.manageReportsToolStripMenuItem.Name = "manageReportsToolStripMenuItem";
            this.manageReportsToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.manageReportsToolStripMenuItem.Text = "Manage Reports";
            // 
            // switchAccountsToolStripMenuItem
            // 
            this.switchAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorModuleToolStripMenuItem,
            this.assistantToolStripMenuItem});
            this.switchAccountsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("switchAccountsToolStripMenuItem.Image")));
            this.switchAccountsToolStripMenuItem.Name = "switchAccountsToolStripMenuItem";
            this.switchAccountsToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.switchAccountsToolStripMenuItem.Text = "Switch Accounts";
            // 
            // doctorModuleToolStripMenuItem
            // 
            this.doctorModuleToolStripMenuItem.Name = "doctorModuleToolStripMenuItem";
            this.doctorModuleToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.doctorModuleToolStripMenuItem.Text = "Doctor";
            this.doctorModuleToolStripMenuItem.Click += new System.EventHandler(this.doctorModuleToolStripMenuItem_Click);
            // 
            // assistantToolStripMenuItem
            // 
            this.assistantToolStripMenuItem.Name = "assistantToolStripMenuItem";
            this.assistantToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.assistantToolStripMenuItem.Text = "Assistant";
            this.assistantToolStripMenuItem.Click += new System.EventHandler(this.assistantToolStripMenuItem_Click);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 704);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminDash";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDash_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistantToolStripMenuItem;
    }
}