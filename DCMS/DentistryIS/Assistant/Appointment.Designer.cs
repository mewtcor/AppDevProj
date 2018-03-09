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
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.ViewAppointmentTextBox = new System.Windows.Forms.TextBox();
            this.EditAppointmentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AppointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.PatientIDTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.ServiceTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DentistComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDataGridView
            // 
            this.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDataGridView.Location = new System.Drawing.Point(13, 83);
            this.AppointmentDataGridView.Name = "AppointmentDataGridView";
            this.AppointmentDataGridView.Size = new System.Drawing.Size(766, 191);
            this.AppointmentDataGridView.TabIndex = 0;
            this.AppointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "View";
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Location = new System.Drawing.Point(599, 49);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.AddAppointmentButton.TabIndex = 2;
            this.AddAppointmentButton.Text = "Add";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // ViewAppointmentTextBox
            // 
            this.ViewAppointmentTextBox.Location = new System.Drawing.Point(50, 49);
            this.ViewAppointmentTextBox.Name = "ViewAppointmentTextBox";
            this.ViewAppointmentTextBox.Size = new System.Drawing.Size(186, 20);
            this.ViewAppointmentTextBox.TabIndex = 3;
            this.ViewAppointmentTextBox.TextChanged += new System.EventHandler(this.ViewAppointmentTextBox_TextChanged);
            // 
            // EditAppointmentButton
            // 
            this.EditAppointmentButton.Location = new System.Drawing.Point(693, 48);
            this.EditAppointmentButton.Name = "EditAppointmentButton";
            this.EditAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.EditAppointmentButton.TabIndex = 4;
            this.EditAppointmentButton.Text = "Edit";
            this.EditAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointment ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patient Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Appointment Date: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Service: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dentist: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Appointment Time: ";
            // 
            // AppointmentIDTextBox
            // 
            this.AppointmentIDTextBox.Enabled = false;
            this.AppointmentIDTextBox.Location = new System.Drawing.Point(106, 303);
            this.AppointmentIDTextBox.Name = "AppointmentIDTextBox";
            this.AppointmentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentIDTextBox.TabIndex = 12;
            // 
            // PatientIDTextBox
            // 
            this.PatientIDTextBox.Enabled = false;
            this.PatientIDTextBox.Location = new System.Drawing.Point(79, 335);
            this.PatientIDTextBox.Name = "PatientIDTextBox";
            this.PatientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientIDTextBox.TabIndex = 13;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(93, 364);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.PatientNameTextBox.TabIndex = 14;
            this.PatientNameTextBox.TextChanged += new System.EventHandler(this.PatientNameTextBox_TextChanged);
            // 
            // ServiceTextBox
            // 
            this.ServiceTextBox.Location = new System.Drawing.Point(396, 367);
            this.ServiceTextBox.Multiline = true;
            this.ServiceTextBox.Name = "ServiceTextBox";
            this.ServiceTextBox.Size = new System.Drawing.Size(194, 37);
            this.ServiceTextBox.TabIndex = 16;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.Location = new System.Drawing.Point(446, 303);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentDatePicker.TabIndex = 17;
            // 
            // AppointmentTimeComboBox
            // 
            this.AppointmentTimeComboBox.FormattingEnabled = true;
            this.AppointmentTimeComboBox.Location = new System.Drawing.Point(446, 329);
            this.AppointmentTimeComboBox.Name = "AppointmentTimeComboBox";
            this.AppointmentTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.AppointmentTimeComboBox.TabIndex = 18;
            // 
            // DentistComboBox
            // 
            this.DentistComboBox.FormattingEnabled = true;
            this.DentistComboBox.Location = new System.Drawing.Point(393, 428);
            this.DentistComboBox.Name = "DentistComboBox";
            this.DentistComboBox.Size = new System.Drawing.Size(121, 21);
            this.DentistComboBox.TabIndex = 19;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.DentistComboBox);
            this.Controls.Add(this.AppointmentTimeComboBox);
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.ServiceTextBox);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.PatientIDTextBox);
            this.Controls.Add(this.AppointmentIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditAppointmentButton);
            this.Controls.Add(this.ViewAppointmentTextBox);
            this.Controls.Add(this.AddAppointmentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Appointment";
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.TextBox ViewAppointmentTextBox;
        private System.Windows.Forms.Button EditAppointmentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AppointmentIDTextBox;
        private System.Windows.Forms.TextBox PatientIDTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox ServiceTextBox;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.ComboBox AppointmentTimeComboBox;
        private System.Windows.Forms.ComboBox DentistComboBox;
    }
}