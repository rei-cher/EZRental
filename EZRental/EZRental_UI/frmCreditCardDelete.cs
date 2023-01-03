using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZRental_BO;

namespace EZRental_UI
{
    public partial class frmCreditCardDelete : Form
    {
        public frmCreditCardDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCC = new CreditCard();

                if (objCC.Load(txtBoxCreditCardNumber.Text.Trim()))
                {
                    if (objCC.Delete(txtBoxCreditCardNumber.Text.Trim()))
                    {
                        MessageBox.Show("Credit Card was successfully deleted");
                        txtBoxCreditCardNumber.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("An error occured during the deletion of Credit Card");
                    }
                }
                else
                {
                    MessageBox.Show("The Credit Card doesn't exist in DataBase");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Credit Card error");
            }
        }
    }
}
