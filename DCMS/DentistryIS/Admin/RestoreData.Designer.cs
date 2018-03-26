namespace DentistryIS
{
    partial class RestoreData
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestoreData = new System.Windows.Forms.Button();
            this.btnBrowseLocation = new System.Windows.Forms.Button();
            this.txtRestoreData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter The Location for Restore Data";
            // 
            // btnRestoreData
            // 
            this.btnRestoreData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreData.Location = new System.Drawing.Point(502, 302);
            this.btnRestoreData.Margin = new System.Windows.Forms.Padding(6);
            this.btnRestoreData.Name = "btnRestoreData";
            this.btnRestoreData.Size = new System.Drawing.Size(224, 60);
            this.btnRestoreData.TabIndex = 6;
            this.btnRestoreData.Text = "Restore Data";
            this.btnRestoreData.UseVisualStyleBackColor = true;
            this.btnRestoreData.Click += new System.EventHandler(this.btnRestoreData_Click);
            // 
            // btnBrowseLocation
            // 
            this.btnBrowseLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseLocation.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseLocation.Location = new System.Drawing.Point(180, 302);
            this.btnBrowseLocation.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowseLocation.Name = "btnBrowseLocation";
            this.btnBrowseLocation.Size = new System.Drawing.Size(224, 60);
            this.btnBrowseLocation.TabIndex = 5;
            this.btnBrowseLocation.Text = "Browse Location";
            this.btnBrowseLocation.UseVisualStyleBackColor = true;
            this.btnBrowseLocation.Click += new System.EventHandler(this.btnBrowseLocation_Click);
            // 
            // txtRestoreData
            // 
            this.txtRestoreData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoreData.Location = new System.Drawing.Point(146, 212);
            this.txtRestoreData.Margin = new System.Windows.Forms.Padding(6);
            this.txtRestoreData.Name = "txtRestoreData";
            this.txtRestoreData.Size = new System.Drawing.Size(660, 37);
            this.txtRestoreData.TabIndex = 4;
            // 
            // RestoreData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestoreData);
            this.Controls.Add(this.btnBrowseLocation);
            this.Controls.Add(this.txtRestoreData);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreData";
            this.Text = "RestoreData";
            this.Load += new System.EventHandler(this.RestoreData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestoreData;
        private System.Windows.Forms.Button btnBrowseLocation;
        private System.Windows.Forms.TextBox txtRestoreData;
    }
}