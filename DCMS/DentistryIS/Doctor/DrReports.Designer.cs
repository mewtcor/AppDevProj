namespace DentistryIS.Doctor
{
    partial class DrReports
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRepTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtParticulars = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtDentistID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.grdFinancial = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DentistComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientIDTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.grdAppointments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancial)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1993, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 65);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2088, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(919, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(378, 128);
            this.label11.TabIndex = 46;
            this.label11.Text = "Reports";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabPage1);
            this.tabReports.Controls.Add(this.tabPage2);
            this.tabReports.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReports.Location = new System.Drawing.Point(62, 256);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(2096, 1043);
            this.tabReports.TabIndex = 47;
            this.tabReports.SelectedIndexChanged += new System.EventHandler(this.tabReports_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grdFinancial);
            this.tabPage1.Location = new System.Drawing.Point(8, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2080, 984);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Financial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRepTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(1429, 674);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 304);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Location = new System.Drawing.Point(233, 37);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 65);
            this.lblCount.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 45);
            this.label9.TabIndex = 13;
            this.label9.Text = "Report Total:";
            // 
            // txtRepTotal
            // 
            this.txtRepTotal.BackColor = System.Drawing.Color.Black;
            this.txtRepTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepTotal.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepTotal.ForeColor = System.Drawing.Color.Lime;
            this.txtRepTotal.Location = new System.Drawing.Point(244, 138);
            this.txtRepTotal.Name = "txtRepTotal";
            this.txtRepTotal.ReadOnly = true;
            this.txtRepTotal.Size = new System.Drawing.Size(296, 65);
            this.txtRepTotal.TabIndex = 12;
            this.txtRepTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 45);
            this.label8.TabIndex = 6;
            this.label8.Text = "Report Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtParticulars);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtPatientID);
            this.groupBox1.Controls.Add(this.txtDentistID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBillID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 654);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 304);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(711, 241);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(340, 43);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtParticulars
            // 
            this.txtParticulars.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticulars.Location = new System.Drawing.Point(711, 132);
            this.txtParticulars.Multiline = true;
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.ReadOnly = true;
            this.txtParticulars.Size = new System.Drawing.Size(340, 95);
            this.txtParticulars.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(711, 72);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(340, 43);
            this.txtDate.TabIndex = 9;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(179, 216);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(220, 43);
            this.txtPatientID.TabIndex = 8;
            // 
            // txtDentistID
            // 
            this.txtDentistID.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDentistID.Location = new System.Drawing.Point(179, 132);
            this.txtDentistID.Name = "txtDentistID";
            this.txtDentistID.ReadOnly = true;
            this.txtDentistID.Size = new System.Drawing.Size(220, 43);
            this.txtDentistID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(618, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Particular/s:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(619, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patient ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dentist ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill ID:";
            // 
            // txtBillID
            // 
            this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.Location = new System.Drawing.Point(179, 58);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(220, 43);
            this.txtBillID.TabIndex = 0;
            // 
            // grdFinancial
            // 
            this.grdFinancial.AllowUserToAddRows = false;
            this.grdFinancial.AllowUserToDeleteRows = false;
            this.grdFinancial.AllowUserToResizeColumns = false;
            this.grdFinancial.AllowUserToResizeRows = false;
            this.grdFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFinancial.Location = new System.Drawing.Point(31, 27);
            this.grdFinancial.Name = "grdFinancial";
            this.grdFinancial.ReadOnly = true;
            this.grdFinancial.RowTemplate.Height = 18;
            this.grdFinancial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFinancial.Size = new System.Drawing.Size(1968, 610);
            this.grdFinancial.TabIndex = 0;
            this.grdFinancial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFinancial_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.grdAppointments);
            this.tabPage2.Location = new System.Drawing.Point(8, 51);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2080, 984);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appointments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AppointmentDatePicker);
            this.groupBox3.Controls.Add(this.DentistComboBox);
            this.groupBox3.Controls.Add(this.ServiceComboBox);
            this.groupBox3.Controls.Add(this.AppointmentTimeComboBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.NoteTextBox);
            this.groupBox3.Controls.Add(this.PatientNameTextBox);
            this.groupBox3.Controls.Add(this.PatientIDTextBox);
            this.groupBox3.Controls.Add(this.AppointmentIDTextBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(31, 654);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1946, 331);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.Location = new System.Drawing.Point(1335, 49);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(371, 43);
            this.AppointmentDatePicker.TabIndex = 79;
            // 
            // DentistComboBox
            // 
            this.DentistComboBox.FormattingEnabled = true;
            this.DentistComboBox.Location = new System.Drawing.Point(1335, 272);
            this.DentistComboBox.Name = "DentistComboBox";
            this.DentistComboBox.Size = new System.Drawing.Size(371, 45);
            this.DentistComboBox.TabIndex = 78;
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(1335, 197);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(371, 45);
            this.ServiceComboBox.TabIndex = 77;
            // 
            // AppointmentTimeComboBox
            // 
            this.AppointmentTimeComboBox.FormattingEnabled = true;
            this.AppointmentTimeComboBox.Location = new System.Drawing.Point(1335, 122);
            this.AppointmentTimeComboBox.Name = "AppointmentTimeComboBox";
            this.AppointmentTimeComboBox.Size = new System.Drawing.Size(371, 45);
            this.AppointmentTimeComboBox.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1198, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 37);
            this.label10.TabIndex = 75;
            this.label10.Text = "Dentist: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1162, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 37);
            this.label12.TabIndex = 74;
            this.label12.Text = "Particular/s: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1072, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 37);
            this.label13.TabIndex = 73;
            this.label13.Text = "Appointment Time: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1074, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 37);
            this.label14.TabIndex = 72;
            this.label14.Text = "Appointment Date: ";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(234, 213);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(530, 105);
            this.NoteTextBox.TabIndex = 70;
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(234, 158);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(530, 43);
            this.PatientNameTextBox.TabIndex = 69;
            // 
            // PatientIDTextBox
            // 
            this.PatientIDTextBox.Location = new System.Drawing.Point(234, 107);
            this.PatientIDTextBox.Name = "PatientIDTextBox";
            this.PatientIDTextBox.ReadOnly = true;
            this.PatientIDTextBox.Size = new System.Drawing.Size(530, 43);
            this.PatientIDTextBox.TabIndex = 68;
            // 
            // AppointmentIDTextBox
            // 
            this.AppointmentIDTextBox.Location = new System.Drawing.Point(234, 49);
            this.AppointmentIDTextBox.Name = "AppointmentIDTextBox";
            this.AppointmentIDTextBox.ReadOnly = true;
            this.AppointmentIDTextBox.Size = new System.Drawing.Size(530, 43);
            this.AppointmentIDTextBox.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(128, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 37);
            this.label15.TabIndex = 66;
            this.label15.Text = "Notes: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 37);
            this.label16.TabIndex = 65;
            this.label16.Text = "Patient Name: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(90, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 37);
            this.label17.TabIndex = 64;
            this.label17.Text = "Patient ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(220, 37);
            this.label18.TabIndex = 63;
            this.label18.Text = "Appointment ID: ";
            // 
            // grdAppointments
            // 
            this.grdAppointments.AllowUserToAddRows = false;
            this.grdAppointments.AllowUserToDeleteRows = false;
            this.grdAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAppointments.Location = new System.Drawing.Point(31, 27);
            this.grdAppointments.Name = "grdAppointments";
            this.grdAppointments.ReadOnly = true;
            this.grdAppointments.RowTemplate.Height = 18;
            this.grdAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAppointments.Size = new System.Drawing.Size(1946, 610);
            this.grdAppointments.TabIndex = 0;
            this.grdAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAppointments_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "Search By Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(263, 201);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(430, 43);
            this.dtpDate.TabIndex = 54;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(699, 196);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(145, 56);
            this.btnShowAll.TabIndex = 55;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // DrReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2226, 1317);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabReports);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "DrReports";
            this.Text = "DrReports";
            this.Load += new System.EventHandler(this.DrReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancial)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView grdFinancial;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView grdAppointments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRepTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtParticulars;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtDentistID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.ComboBox DentistComboBox;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.ComboBox AppointmentTimeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox PatientIDTextBox;
        private System.Windows.Forms.TextBox AppointmentIDTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}