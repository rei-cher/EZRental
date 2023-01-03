﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZRental_UI
{
    public partial class frmMainWelcomeForm : Form
    {
        public frmMainWelcomeForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnERP_Click(object sender, EventArgs e)
        {
            frmERPSystemForm objERP = new frmERPSystemForm();
            this.Hide();
            objERP.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
