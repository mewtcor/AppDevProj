﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentistryIS
{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDash drForm = new DoctorDash();
            drForm.Show();
        }

        private void assistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssistantDash asForm = new AssistantDash();
            asForm.Show();    
        }
    }
}