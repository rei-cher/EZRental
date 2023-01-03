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
    public partial class frmCreditCardRegistration : Form
    {
        public frmCreditCardRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCC = new CreditCard();

                objCC.CreditCardNumber = txtBoxCreditCardNumber.Text.Trim();
                objCC.CreditCardOwnerName = txtBoxCardOwnerName.Text.Trim();
                objCC.CreditCardIssuingCompany = txtBoxCreditCardCompany.Text.Trim();
                objCC.MerchantCode = Convert.ToByte(txtBoxMerchantCode.Text);
                objCC.ExpDate = dateTimeExpiration.Value;
                objCC.AddressLine1 = txtBoxAddressLine1.Text.Trim();
                objCC.AddressLine2 = txtBoxAddressLine2.Text.Trim();
                objCC.City = txtBoxCity.Text.Trim();
                objCC.State = cmbBoxState.SelectedValue.ToString();
                objCC.ZipCode = txtBoxZipCode.Text;
                objCC.Country = cmbBoxCountry.SelectedValue.ToString();
                objCC.CreditCardLimit = Convert.ToDecimal(txtBoxCreditCardLimit.Text);
                objCC.CreditCardBalance = Convert.ToDecimal(txtBoxCreditCardBalance.Text);

                if(cmbBoxActivate.Text == "Activate")
                {
                    objCC.Activate();
                }
                else
                {
                    objCC.Deactivate();
                }

                if (objCC.Insert())
                {
                    MessageBox.Show("Customer Added");

                    txtBoxCreditCardNumber.Text = "";
                    txtBoxCardOwnerName.Text = "";
                    txtBoxCreditCardCompany.Text = "";
                    txtBoxMerchantCode.Text = "";
                    txtBoxAddressLine1.Text = "";
                    txtBoxAddressLine2.Text = "";
                    txtBoxCity.Text = "";
                    txtBoxZipCode.Text = "";
                    txtBoxCreditCardLimit.Text = "3000";
                    txtBoxCreditCardBalance.Text = "3000";
                }
                else
                {
                    MessageBox.Show("Error. Credit Card wasn't added");
                }
            }
            catch
            {
                MessageBox.Show("Error. Credit Card wasn't added");
            }
        }

        private void frmCreditCardRegistration_Load_1(object sender, EventArgs e)
        {
            cmbBoxState.DataSource = USState.GetAllUSStates();
            cmbBoxState.DisplayMember = "StateName";
            cmbBoxState.ValueMember = "StateCode";
            cmbBoxState.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxCountry.DataSource = Country.GetAllCountries();
            cmbBoxCountry.DisplayMember = "CountryName";
            cmbBoxCountry.ValueMember = "CountryName";
            cmbBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxActivate.Items.Add("Activate");
            cmbBoxActivate.Items.Add("Deactivate");
            cmbBoxActivate.SelectedText = "Activate";

            txtBoxCreditCardBalance.Text = "3000";
            txtBoxCreditCardLimit.Text = "3000";
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }
    }
}
