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
    public partial class frmCreditCardUpdate : Form
    {
        public frmCreditCardUpdate()
        {
            InitializeComponent();
        }

        private void lblCreditCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCC = new CreditCard();

                if (objCC.Load(txtBoxCreditCardNumber.Text.Trim()))
                {
                    txtBoxCardNumber.Text = objCC.CreditCardNumber;
                    txtBoxCardOwnerName.Text = objCC.CreditCardOwnerName;
                    txtBoxCreditCardCompany.Text = objCC.CreditCardIssuingCompany;
                    txtBoxMerchantCode.Text = objCC.MerchantCode.ToString();
                    dateTimeExpirationDate.Value = objCC.ExpDate;
                    txtBoxAddressLine1.Text = objCC.AddressLine1;
                    txtBoxAddressLine2.Text = objCC.AddressLine2;
                    txtBoxCity.Text = objCC.City;
                    cmbBoxState.Text = objCC.State;
                    txtBoxZipCode.Text = objCC.ZipCode;
                    cmbBoxCountry.Text = objCC.Country;
                    txtBoxCreditCardLimit.Text = objCC.CreditCardLimit.ToString();
                    txtBoxCreditCardBalance.Text = objCC.CreditCardBalance.ToString();
                    if(objCC.ActivationStatus == true)
                    {
                        cmbBoxActivationStatus.Text = "Activate";
                    }
                    else
                    {
                        cmbBoxActivationStatus.Text = "Deactivate";
                    }
                    
                }
                else
                {
                    MessageBox.Show("Credit Card was not found");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in search");
            }
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
                objCC.ExpDate = dateTimeExpirationDate.Value;
                objCC.AddressLine1 = txtBoxAddressLine1.Text.Trim();
                objCC.AddressLine2 = txtBoxAddressLine2.Text.Trim();
                objCC.City = txtBoxCity.Text.Trim();
                objCC.State = cmbBoxState.SelectedValue.ToString();
                objCC.ZipCode = txtBoxZipCode.Text;
                objCC.Country = cmbBoxCountry.SelectedValue.ToString();
                objCC.CreditCardLimit = Convert.ToDecimal(txtBoxCreditCardLimit.Text);
                objCC.CreditCardBalance = Convert.ToDecimal(txtBoxCreditCardBalance.Text);

                if (cmbBoxActivationStatus.Text == "Activate")
                {
                    objCC.Activate();
                }
                else
                {
                    objCC.Deactivate();
                }

                if (objCC.Update())
                {
                    MessageBox.Show("Inforamtion has been Updated");

                    txtBoxCardNumber.Text = "";
                    txtBoxCreditCardNumber.Text = "";
                    txtBoxCardOwnerName.Text = "";
                    txtBoxCreditCardCompany.Text = "";
                    txtBoxMerchantCode.Text = "";
                    txtBoxAddressLine1.Text = "";
                    txtBoxAddressLine2.Text = "";
                    txtBoxCity.Text = "";
                    txtBoxZipCode.Text = "";
                    txtBoxCreditCardLimit.Text = "";
                    txtBoxCreditCardBalance.Text = "";
                }
                else
                {
                    MessageBox.Show("Error. Credit Card wasn't updated");
                }
            }
            catch
            {
                MessageBox.Show("Error. Credit Card wasn't updated");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreditCardUpdate_Load(object sender, EventArgs e)
        {
            cmbBoxState.DataSource = USState.GetAllUSStates();
            cmbBoxState.DisplayMember = "StateName";
            cmbBoxState.ValueMember = "StateCode";
            cmbBoxState.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxCountry.DataSource = Country.GetAllCountries();
            cmbBoxCountry.DisplayMember = "CountryName";
            cmbBoxCountry.ValueMember = "CountryName";
            cmbBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxActivationStatus.Items.Add("Activate");
            cmbBoxActivationStatus.Items.Add("Deactivate");
            cmbBoxActivationStatus.SelectedText = "Activate";
        }
    }
}
