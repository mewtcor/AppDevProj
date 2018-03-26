namespace DentistryIS.Assistant
{
    partial class Appointment
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
            this.AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewAppointmentTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditAppointmentButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.DentistComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentTimeComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientIDTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDataGridView
            // 
            this.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDataGridView.Location = new System.Drawing.Point(72, 246);
            this.AppointmentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentDataGridView.Name = "AppointmentDataGridView";
            this.AppointmentDataGridView.Size = new System.Drawing.Size(2088, 469);
            this.AppointmentDataGridView.TabIndex = 0;
            this.AppointmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDataGridView_CellClick);
            this.AppointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "View";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewAppointmentTextBox
            // 
            this.ViewAppointmentTextBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAppointmentTextBox.Location = new System.Drawing.Point(150, 198);
            this.ViewAppointmentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewAppointmentTextBox.Name = "ViewAppointmentTextBox";
            this.ViewAppointmentTextBox.Size = new System.Drawing.Size(482, 43);
            this.ViewAppointmentTextBox.TabIndex = 3;
            this.ViewAppointmentTextBox.TextChanged += new System.EventHandler(this.ViewAppointmentTextBox_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1958, 1209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 87);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.EditAppointmentButton);
            this.groupBox1.Controls.Add(this.AddAppointmentButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.ServiceComboBox);
            this.groupBox1.Controls.Add(this.DentistComboBox);
            this.groupBox1.Controls.Add(this.AppointmentTimeComboBox);
            this.groupBox1.Controls.Add(this.AppointmentDatePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NoteTextBox);
            this.groupBox1.Controls.Add(this.PatientNameTextBox);
            this.groupBox1.Controls.Add(this.PatientIDTextBox);
            this.groupBox1.Controls.Add(this.AppointmentIDTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(72, 736);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2094, 454);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(1858, 271);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(167, 81);
            this.CancelButton.TabIndex = 41;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditAppointmentButton
            // 
            this.EditAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAppointmentButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAppointmentButton.Location = new System.Drawing.Point(1858, 131);
            this.EditAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditAppointmentButton.Name = "EditAppointmentButton";
            this.EditAppointmentButton.Size = new System.Drawing.Size(167, 81);
            this.EditAppointmentButton.TabIndex = 40;
            this.EditAppointmentButton.Text = "Edit";
            this.EditAppointmentButton.UseVisualStyleBackColor = true;
            this.EditAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAppointmentButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentButton.Location = new System.Drawing.Point(1628, 131);
            this.AddAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(167, 81);
            this.AddAppointmentButton.TabIndex = 39;
            this.AddAppointmentButton.Text = "Add";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(1628, 271);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(167, 81);
            this.ClearButton.TabIndex = 38;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(985, 262);
            this.ServiceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(567, 45);
            this.ServiceComboBox.TabIndex = 37;
            // 
            // DentistComboBox
            // 
            this.DentistComboBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DentistComboBox.FormattingEnabled = true;
            this.DentistComboBox.Location = new System.Drawing.Point(985, 349);
            this.DentistComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DentistComboBox.Name = "DentistComboBox";
            this.DentistComboBox.Size = new System.Drawing.Size(567, 45);
            this.DentistComboBox.TabIndex = 36;
            // 
            // AppointmentTimeComboBox
            // 
            this.AppointmentTimeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentTimeComboBox.FormattingEnabled = true;
            this.AppointmentTimeComboBox.Location = new System.Drawing.Point(1112, 175);
            this.AppointmentTimeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentTimeComboBox.Name = "AppointmentTimeComboBox";
            this.AppointmentTimeComboBox.Size = new System.Drawing.Size(440, 45);
            this.AppointmentTimeComboBox.TabIndex = 35;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDatePicker.Location = new System.Drawing.Point(1112, 90);
            this.AppointmentDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(440, 43);
            this.AppointmentDatePicker.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(866, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 37);
            this.label8.TabIndex = 33;
            this.label8.Text = "Appointment Time: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(865, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 37);
            this.label7.TabIndex = 32;
            this.label7.Text = "Dentist: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(866, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 37);
            this.label6.TabIndex = 31;
            this.label6.Text = "Service: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Appointment Date: ";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTextBox.Location = new System.Drawing.Point(162, 258);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(468, 138);
            this.NoteTextBox.TabIndex = 29;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameTextBox.Location = new System.Drawing.Point(263, 204);
            this.PatientNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(367, 43);
            this.PatientNameTextBox.TabIndex = 28;
            // 
            // PatientIDTextBox
            // 
            this.PatientIDTextBox.Enabled = false;
            this.PatientIDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDTextBox.Location = new System.Drawing.Point(202, 150);
            this.PatientIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientIDTextBox.Name = "PatientIDTextBox";
            this.PatientIDTextBox.Size = new System.Drawing.Size(428, 43);
            this.PatientIDTextBox.TabIndex = 27;
            // 
            // AppointmentIDTextBox
            // 
            this.AppointmentIDTextBox.Enabled = false;
            this.AppointmentIDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentIDTextBox.Location = new System.Drawing.Point(282, 96);
            this.AppointmentIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentIDTextBox.Name = "AppointmentIDTextBox";
            this.AppointmentIDTextBox.Size = new System.Drawing.Size(348, 43);
            this.AppointmentIDTextBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 37);
            this.label9.TabIndex = 25;
            this.label9.Text = "Note: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Patient Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Patient ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Appointment ID: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(72, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2088, 133);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(814, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(656, 128);
            this.label11.TabIndex = 48;
            this.label11.Text = "Appointments";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2216, 1404);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ViewAppointmentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ViewAppointmentTextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.ComboBox DentistComboBox;
        private System.Windows.Forms.ComboBox AppointmentTimeComboBox;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox PatientIDTextBox;
        private System.Windows.Forms.TextBox AppointmentIDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditAppointmentButton;
        private System.Windows.Forms.Button AddAppointmentButton;
    }
}