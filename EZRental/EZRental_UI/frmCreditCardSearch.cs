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

    public partial class frmCreditCardSearch : Form
    {
        public frmCreditCardSearch()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCC = new CreditCard();

                if (objCC.Load(txtBoxCardNumber.Text.Trim()))
                {
                    objCC.Print();
                }
                else
                {
                    MessageBox.Show("Credit Card is not found");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Search Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCC = new CreditCard();

                if (objCC.Load(txtBoxCardNumber.Text.Trim()))
                {
                    txtBoxCreditCardNumber.Text = objCC.CreditCardNumber;
                    txtBoxCardOwnerName.Text = objCC.CreditCardOwnerName;
                    txtBoxCreditCardCompany.Text = objCC.CreditCardIssuingCompany;
                    txtBoxMerchantCode.Text = objCC.MerchantCode.ToString();
                    txtBoxExpirationDate.Text = objCC.ExpDate.ToString();
                    txtBoxAddressLine1.Text = objCC.AddressLine1;
                    txtBoxAddressLine2.Text = objCC.AddressLine2;
                    txtBoxCity.Text = objCC.City;
                    txtBoxState.Text = objCC.State;
                    txtBoxZipCode.Text = objCC.ZipCode;
                    txtBoxCountry.Text = objCC.Country;
                    txtBoxCreditCardLimit.Text = objCC.CreditCardLimit.ToString();
                    txtBoxCreditCardBalance.Text = objCC.CreditCardBalance.ToString();

                    if (objCC.ActivationStatus)
                    {
                        txtBoxActivationStatus.Text = "Acivated";
                    }
                    else
                    {
                        txtBoxActivationStatus.Text = "Deactivated";
                    }
                }
                else
                {
                    MessageBox.Show("Credit Card is not found");

                    txtBoxCardNumber.Text = "";
                    txtBoxCreditCardNumber.Text = "";
                    txtBoxCardOwnerName.Text = "";
                    txtBoxCreditCardCompany.Text = "";
                    txtBoxMerchantCode.Text = "";
                    txtBoxExpirationDate.Text = "";
                    txtBoxAddressLine1.Text = "";
                    txtBoxAddressLine2.Text = "";
                    txtBoxCity.Text = "";
                    txtBoxState.Text = "";
                    txtBoxZipCode.Text = "";
                    txtBoxCountry.Text = "";
                    txtBoxCreditCardLimit.Text = "";
                    txtBoxCreditCardBalance.Text = "";
                    txtBoxActivationStatus.Text = "";
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in search");
            }
        }
    }
}
