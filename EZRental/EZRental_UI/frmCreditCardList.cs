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
    public partial class frmCreditCardList : Form
    {
        public frmCreditCardList()
        {
            InitializeComponent();
        }

        private void dgvCreditCardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListAllCreditCards_Click(object sender, EventArgs e)
        {
            dgvCreditCardList.DataSource = CreditCard.GetAllCreditCards();

            dgvCreditCardList.Columns["cohCreditCardNumber"].DataPropertyName = "CreditCardNumber";
            dgvCreditCardList.Columns["cohCreditCardOwnerName"].DataPropertyName = "CreditCardOwnerName";
            dgvCreditCardList.Columns["cohCreditCardBank"].DataPropertyName = "CreditCardIssuingCompany";
            dgvCreditCardList.Columns["cohMerchantCode"].DataPropertyName = "MerchantCode";
            dgvCreditCardList.Columns["cohExpirationDate"].DataPropertyName = "ExpDate";
            dgvCreditCardList.Columns["cohAddressLine1"].DataPropertyName = "AddressLine1";
            dgvCreditCardList.Columns["cohAddressLine2"].DataPropertyName = "AddressLine2";
            dgvCreditCardList.Columns["cohCity"].DataPropertyName = "City";
            dgvCreditCardList.Columns["cohState"].DataPropertyName = "State";
            dgvCreditCardList.Columns["cohZipCode"].DataPropertyName = "ZipCode";
            dgvCreditCardList.Columns["cohCountry"].DataPropertyName = "Country";
            dgvCreditCardList.Columns["cohCreditCardLimit"].DataPropertyName = "CreditCardLimit";
            dgvCreditCardList.Columns["cohCreditCardBalance"].DataPropertyName = "CreditCardBalance";
            dgvCreditCardList.Columns["cohActivationStatus"].DataPropertyName = "ActivationStatus";
        }

        private void frmCreditCardList_Load(object sender, EventArgs e)
        {
            dgvCreditCardList.AutoGenerateColumns = false;
        }

    }
}
