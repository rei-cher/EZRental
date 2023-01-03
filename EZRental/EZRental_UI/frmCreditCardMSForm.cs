using System;
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
    public partial class frmCreditCardMSForm : Form
    {
        public frmCreditCardMSForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCreditCardSearch objCCS = new frmCreditCardSearch();
            this.Hide();
            objCCS.ShowDialog();
            this.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmCreditCardRegistration objCCR = new frmCreditCardRegistration();
            this.Hide();
            objCCR.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreditCardUpdate objCCU = new frmCreditCardUpdate();
            this.Hide();
            objCCU.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmCreditCardDelete objCCD = new frmCreditCardDelete();
            this.Hide();
            objCCD.ShowDialog();
            this.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmCreditCardList objCCL = new frmCreditCardList();
            this.Hide();
            objCCL.ShowDialog();
            this.Show();
        }
    }
}
