namespace DentistryIS
{
    partial class BackUpData
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
            this.txtBackUp = new System.Windows.Forms.TextBox();
            this.btnBrowseLocation = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBackUp
            // 
            this.txtBackUp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackUp.Location = new System.Drawing.Point(150, 210);
            this.txtBackUp.Margin = new System.Windows.Forms.Padding(6);
            this.txtBackUp.Name = "txtBackUp";
            this.txtBackUp.Size = new System.Drawing.Size(660, 37);
            this.txtBackUp.TabIndex = 0;
            // 
            // btnBrowseLocation
            // 
            this.btnBrowseLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseLocation.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseLocation.Location = new System.Drawing.Point(184, 300);
            this.btnBrowseLocation.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowseLocation.Name = "btnBrowseLocation";
            this.btnBrowseLocation.Size = new System.Drawing.Size(224, 64);
            this.btnBrowseLocation.TabIndex = 1;
            this.btnBrowseLocation.Text = "Browse Location";
            this.btnBrowseLocation.UseVisualStyleBackColor = true;
            this.btnBrowseLocation.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUp.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.Location = new System.Drawing.Point(506, 300);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(224, 64);
            this.btnBackUp.TabIndex = 2;
            this.btnBackUp.Text = "BackUp Data";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter The Location for BackUp";
            // 
            // BackUpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnBrowseLocation);
            this.Controls.Add(this.txtBackUp);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackUpData";
            this.Text = "BackUpData";
            this.Load += new System.EventHandler(this.BackUpData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackUp;
        private System.Windows.Forms.Button btnBrowseLocation;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Label label1;
    }
}