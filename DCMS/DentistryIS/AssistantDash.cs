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
    public partial class AssistantDash : Form
    {
        public AssistantDash()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adDash = new AdminDash();
            adDash.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDash drDash = new DoctorDash();
            drDash.Show();
        }
    }
}