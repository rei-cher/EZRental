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
    public partial class frmERPSystemForm : Form
    {
        public frmERPSystemForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreditCardMS_Click(object sender, EventArgs e)
        {
            frmCreditCardMSForm objMS = new frmCreditCardMSForm();
            this.Hide();
            objMS.ShowDialog();
            this.Show();
        }
    }
}
