
namespace EZRental_UI
{
    partial class frmCreditCardUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grBoxCreditCardNumber = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblCreditCardNumberInstructions = new System.Windows.Forms.Label();
            this.grBoxCardInformation = new System.Windows.Forms.GroupBox();
            this.cmbBoxActivationStatus = new System.Windows.Forms.ComboBox();
            this.cmbBoxCountry = new System.Windows.Forms.ComboBox();
            this.cmbBoxState = new System.Windows.Forms.ComboBox();
            this.dateTimeExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCreditCardBalance = new System.Windows.Forms.TextBox();
            this.txtBoxCreditCardLimit = new System.Windows.Forms.TextBox();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtBoxAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtBoxCreditCardCompany = new System.Windows.Forms.TextBox();
            this.txtBoxCardOwnerName = new System.Windows.Forms.TextBox();
            this.txtBoxCardNumber = new System.Windows.Forms.TextBox();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.lblCreditCardBalance = new System.Windows.Forms.Label();
            this.lblCreditCardLimit = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.lblCardOwnerName = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCreditCardInformation = new System.Windows.Forms.Label();
            this.grBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMerchantCode = new System.Windows.Forms.Label();
            this.txtBoxMerchantCode = new System.Windows.Forms.TextBox();
            this.grBoxCreditCardNumber.SuspendLayout();
            this.grBoxCardInformation.SuspendLayout();
            this.grBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Update";
            // 
            // grBoxCreditCardNumber
            // 
            this.grBoxCreditCardNumber.Controls.Add(this.btnSearch);
            this.grBoxCreditCardNumber.Controls.Add(this.txtBoxCreditCardNumber);
            this.grBoxCreditCardNumber.Controls.Add(this.lblCreditCardNumber);
            this.grBoxCreditCardNumber.Controls.Add(this.lblCreditCardNumberInstructions);
            this.grBoxCreditCardNumber.Location = new System.Drawing.Point(12, 44);
            this.grBoxCreditCardNumber.Name = "grBoxCreditCardNumber";
            this.grBoxCreditCardNumber.Size = new System.Drawing.Size(583, 165);
            this.grBoxCreditCardNumber.TabIndex = 1;
            this.grBoxCreditCardNumber.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(420, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxCreditCardNumber
            // 
            this.txtBoxCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardNumber.Location = new System.Drawing.Point(213, 121);
            this.txtBoxCreditCardNumber.Name = "txtBoxCreditCardNumber";
            this.txtBoxCreditCardNumber.Size = new System.Drawing.Size(179, 26);
            this.txtBoxCreditCardNumber.TabIndex = 2;
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(11, 118);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(196, 24);
            this.lblCreditCardNumber.TabIndex = 1;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            this.lblCreditCardNumber.Click += new System.EventHandler(this.lblCreditCardNumber_Click);
            // 
            // lblCreditCardNumberInstructions
            // 
            this.lblCreditCardNumberInstructions.AutoSize = true;
            this.lblCreditCardNumberInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumberInstructions.Location = new System.Drawing.Point(7, 20);
            this.lblCreditCardNumberInstructions.Name = "lblCreditCardNumberInstructions";
            this.lblCreditCardNumberInstructions.Size = new System.Drawing.Size(485, 48);
            this.lblCreditCardNumberInstructions.TabIndex = 0;
            this.lblCreditCardNumberInstructions.Text = "Enter Card Number of Credit Card to Update and Click \r\nSearch button to retrieve " +
    "the Credit Card Record:";
            this.lblCreditCardNumberInstructions.UseCompatibleTextRendering = true;
            // 
            // grBoxCardInformation
            // 
            this.grBoxCardInformation.Controls.Add(this.txtBoxMerchantCode);
            this.grBoxCardInformation.Controls.Add(this.lblMerchantCode);
            this.grBoxCardInformation.Controls.Add(this.cmbBoxActivationStatus);
            this.grBoxCardInformation.Controls.Add(this.cmbBoxCountry);
            this.grBoxCardInformation.Controls.Add(this.cmbBoxState);
            this.grBoxCardInformation.Controls.Add(this.dateTimeExpirationDate);
            this.grBoxCardInformation.Controls.Add(this.txtBoxCreditCardBalance);
            this.grBoxCardInformation.Controls.Add(this.txtBoxCreditCardLimit);
            this.grBoxCardInformation.Controls.Add(this.txtBoxZipCode);
            this.grBoxCardInformation.Controls.Add(this.txtBoxCity);
            this.grBoxCardInformation.Controls.Add(this.txtBoxAddressLine2);
            this.grBoxCardInformation.Controls.Add(this.txtBoxAddressLine1);
            this.grBoxCardInformation.Controls.Add(this.txtBoxCreditCardCompany);
            this.grBoxCardInformation.Controls.Add(this.txtBoxCardOwnerName);
            this.grBoxCardInformation.Controls.Add(this.txtBoxCardNumber);
            this.grBoxCardInformation.Controls.Add(this.lblActivationStatus);
            this.grBoxCardInformation.Controls.Add(this.lblCreditCardBalance);
            this.grBoxCardInformation.Controls.Add(this.lblCreditCardLimit);
            this.grBoxCardInformation.Controls.Add(this.lblCountry);
            this.grBoxCardInformation.Controls.Add(this.lblZipCode);
            this.grBoxCardInformation.Controls.Add(this.lblState);
            this.grBoxCardInformation.Controls.Add(this.lblCity);
            this.grBoxCardInformation.Controls.Add(this.lblAddressLine2);
            this.grBoxCardInformation.Controls.Add(this.lblAddressLine1);
            this.grBoxCardInformation.Controls.Add(this.lblExpirationDate);
            this.grBoxCardInformation.Controls.Add(this.lblCreditCardCompany);
            this.grBoxCardInformation.Controls.Add(this.lblCardOwnerName);
            this.grBoxCardInformation.Controls.Add(this.lblCardNumber);
            this.grBoxCardInformation.Controls.Add(this.lblCreditCardInformation);
            this.grBoxCardInformation.Location = new System.Drawing.Point(13, 228);
            this.grBoxCardInformation.Name = "grBoxCardInformation";
            this.grBoxCardInformation.Size = new System.Drawing.Size(582, 588);
            this.grBoxCardInformation.TabIndex = 2;
            this.grBoxCardInformation.TabStop = false;
            // 
            // cmbBoxActivationStatus
            // 
            this.cmbBoxActivationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxActivationStatus.FormattingEnabled = true;
            this.cmbBoxActivationStatus.Location = new System.Drawing.Point(259, 504);
            this.cmbBoxActivationStatus.Name = "cmbBoxActivationStatus";
            this.cmbBoxActivationStatus.Size = new System.Drawing.Size(232, 28);
            this.cmbBoxActivationStatus.TabIndex = 25;
            // 
            // cmbBoxCountry
            // 
            this.cmbBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxCountry.FormattingEnabled = true;
            this.cmbBoxCountry.Location = new System.Drawing.Point(259, 402);
            this.cmbBoxCountry.Name = "cmbBoxCountry";
            this.cmbBoxCountry.Size = new System.Drawing.Size(232, 28);
            this.cmbBoxCountry.TabIndex = 24;
            // 
            // cmbBoxState
            // 
            this.cmbBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxState.FormattingEnabled = true;
            this.cmbBoxState.Location = new System.Drawing.Point(259, 334);
            this.cmbBoxState.Name = "cmbBoxState";
            this.cmbBoxState.Size = new System.Drawing.Size(232, 28);
            this.cmbBoxState.TabIndex = 23;
            // 
            // dateTimeExpirationDate
            // 
            this.dateTimeExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpirationDate.Location = new System.Drawing.Point(259, 195);
            this.dateTimeExpirationDate.Name = "dateTimeExpirationDate";
            this.dateTimeExpirationDate.Size = new System.Drawing.Size(232, 26);
            this.dateTimeExpirationDate.TabIndex = 22;
            // 
            // txtBoxCreditCardBalance
            // 
            this.txtBoxCreditCardBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardBalance.Location = new System.Drawing.Point(259, 470);
            this.txtBoxCreditCardBalance.Name = "txtBoxCreditCardBalance";
            this.txtBoxCreditCardBalance.Size = new System.Drawing.Size(232, 26);
            this.txtBoxCreditCardBalance.TabIndex = 21;
            // 
            // txtBoxCreditCardLimit
            // 
            this.txtBoxCreditCardLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardLimit.Location = new System.Drawing.Point(259, 436);
            this.txtBoxCreditCardLimit.Name = "txtBoxCreditCardLimit";
            this.txtBoxCreditCardLimit.Size = new System.Drawing.Size(232, 26);
            this.txtBoxCreditCardLimit.TabIndex = 20;
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZipCode.Location = new System.Drawing.Point(259, 368);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(232, 26);
            this.txtBoxZipCode.TabIndex = 19;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(259, 300);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(232, 26);
            this.txtBoxCity.TabIndex = 18;
            // 
            // txtBoxAddressLine2
            // 
            this.txtBoxAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddressLine2.Location = new System.Drawing.Point(259, 266);
            this.txtBoxAddressLine2.Name = "txtBoxAddressLine2";
            this.txtBoxAddressLine2.Size = new System.Drawing.Size(232, 26);
            this.txtBoxAddressLine2.TabIndex = 17;
            // 
            // txtBoxAddressLine1
            // 
            this.txtBoxAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddressLine1.Location = new System.Drawing.Point(259, 232);
            this.txtBoxAddressLine1.Name = "txtBoxAddressLine1";
            this.txtBoxAddressLine1.Size = new System.Drawing.Size(232, 26);
            this.txtBoxAddressLine1.TabIndex = 16;
            // 
            // txtBoxCreditCardCompany
            // 
            this.txtBoxCreditCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardCompany.Location = new System.Drawing.Point(259, 130);
            this.txtBoxCreditCardCompany.Name = "txtBoxCreditCardCompany";
            this.txtBoxCreditCardCompany.Size = new System.Drawing.Size(232, 26);
            this.txtBoxCreditCardCompany.TabIndex = 15;
            // 
            // txtBoxCardOwnerName
            // 
            this.txtBoxCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCardOwnerName.Location = new System.Drawing.Point(259, 96);
            this.txtBoxCardOwnerName.Name = "txtBoxCardOwnerName";
            this.txtBoxCardOwnerName.Size = new System.Drawing.Size(232, 26);
            this.txtBoxCardOwnerName.TabIndex = 14;
            // 
            // txtBoxCardNumber
            // 
            this.txtBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCardNumber.Location = new System.Drawing.Point(259, 62);
            this.txtBoxCardNumber.Name = "txtBoxCardNumber";
            this.txtBoxCardNumber.ReadOnly = true;
            this.txtBoxCardNumber.Size = new System.Drawing.Size(232, 26);
            this.txtBoxCardNumber.TabIndex = 4;
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivationStatus.Location = new System.Drawing.Point(14, 499);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblActivationStatus.Size = new System.Drawing.Size(145, 34);
            this.lblActivationStatus.TabIndex = 13;
            this.lblActivationStatus.Text = "Activation Status";
            // 
            // lblCreditCardBalance
            // 
            this.lblCreditCardBalance.AutoSize = true;
            this.lblCreditCardBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardBalance.Location = new System.Drawing.Point(14, 465);
            this.lblCreditCardBalance.Name = "lblCreditCardBalance";
            this.lblCreditCardBalance.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardBalance.Size = new System.Drawing.Size(177, 34);
            this.lblCreditCardBalance.TabIndex = 12;
            this.lblCreditCardBalance.Text = "Credit Card Balance";
            // 
            // lblCreditCardLimit
            // 
            this.lblCreditCardLimit.AutoSize = true;
            this.lblCreditCardLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardLimit.Location = new System.Drawing.Point(14, 431);
            this.lblCreditCardLimit.Name = "lblCreditCardLimit";
            this.lblCreditCardLimit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardLimit.Size = new System.Drawing.Size(147, 34);
            this.lblCreditCardLimit.TabIndex = 11;
            this.lblCreditCardLimit.Text = "Credit Card Limit";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(14, 397);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCountry.Size = new System.Drawing.Size(75, 34);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(14, 363);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblZipCode.Size = new System.Drawing.Size(88, 34);
            this.lblZipCode.TabIndex = 9;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(14, 329);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblState.Size = new System.Drawing.Size(51, 34);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(14, 295);
            this.lblCity.Name = "lblCity";
            this.lblCity.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCity.Size = new System.Drawing.Size(40, 34);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(14, 261);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAddressLine2.Size = new System.Drawing.Size(136, 34);
            this.lblAddressLine2.TabIndex = 6;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(14, 227);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAddressLine1.Size = new System.Drawing.Size(136, 34);
            this.lblAddressLine1.TabIndex = 5;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(14, 193);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblExpirationDate.Size = new System.Drawing.Size(137, 34);
            this.lblExpirationDate.TabIndex = 4;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardCompany.Location = new System.Drawing.Point(14, 125);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardCompany.Size = new System.Drawing.Size(190, 34);
            this.lblCreditCardCompany.TabIndex = 3;
            this.lblCreditCardCompany.Text = "Credit Card Company";
            // 
            // lblCardOwnerName
            // 
            this.lblCardOwnerName.AutoSize = true;
            this.lblCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardOwnerName.Location = new System.Drawing.Point(14, 91);
            this.lblCardOwnerName.Name = "lblCardOwnerName";
            this.lblCardOwnerName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCardOwnerName.Size = new System.Drawing.Size(168, 34);
            this.lblCardOwnerName.TabIndex = 2;
            this.lblCardOwnerName.Text = "Card Owner Name";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(14, 57);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCardNumber.Size = new System.Drawing.Size(196, 34);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Credit Card Number";
            // 
            // lblCreditCardInformation
            // 
            this.lblCreditCardInformation.AutoSize = true;
            this.lblCreditCardInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardInformation.Location = new System.Drawing.Point(7, 20);
            this.lblCreditCardInformation.Name = "lblCreditCardInformation";
            this.lblCreditCardInformation.Size = new System.Drawing.Size(354, 24);
            this.lblCreditCardInformation.TabIndex = 0;
            this.lblCreditCardInformation.Text = "Update Required Credit Card information:";
            // 
            // grBoxButtons
            // 
            this.grBoxButtons.Controls.Add(this.btnApply);
            this.grBoxButtons.Controls.Add(this.btnExit);
            this.grBoxButtons.Location = new System.Drawing.Point(12, 822);
            this.grBoxButtons.Name = "grBoxButtons";
            this.grBoxButtons.Size = new System.Drawing.Size(582, 108);
            this.grBoxButtons.TabIndex = 3;
            this.grBoxButtons.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(419, 32);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(139, 49);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(222, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMerchantCode
            // 
            this.lblMerchantCode.AutoSize = true;
            this.lblMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantCode.Location = new System.Drawing.Point(14, 159);
            this.lblMerchantCode.Name = "lblMerchantCode";
            this.lblMerchantCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblMerchantCode.Size = new System.Drawing.Size(140, 34);
            this.lblMerchantCode.TabIndex = 26;
            this.lblMerchantCode.Text = "Merchant Code";
            // 
            // txtBoxMerchantCode
            // 
            this.txtBoxMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMerchantCode.Location = new System.Drawing.Point(259, 159);
            this.txtBoxMerchantCode.Name = "txtBoxMerchantCode";
            this.txtBoxMerchantCode.Size = new System.Drawing.Size(232, 26);
            this.txtBoxMerchantCode.TabIndex = 27;
            // 
            // frmCreditCardUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 942);
            this.Controls.Add(this.grBoxButtons);
            this.Controls.Add(this.grBoxCardInformation);
            this.Controls.Add(this.grBoxCreditCardNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreditCardUpdate";
            this.Text = "Credit Card Update";
            this.Load += new System.EventHandler(this.frmCreditCardUpdate_Load);
            this.grBoxCreditCardNumber.ResumeLayout(false);
            this.grBoxCreditCardNumber.PerformLayout();
            this.grBoxCardInformation.ResumeLayout(false);
            this.grBoxCardInformation.PerformLayout();
            this.grBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grBoxCreditCardNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxCreditCardNumber;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblCreditCardNumberInstructions;
        private System.Windows.Forms.GroupBox grBoxCardInformation;
        private System.Windows.Forms.ComboBox cmbBoxActivationStatus;
        private System.Windows.Forms.ComboBox cmbBoxCountry;
        private System.Windows.Forms.ComboBox cmbBoxState;
        private System.Windows.Forms.DateTimePicker dateTimeExpirationDate;
        private System.Windows.Forms.TextBox txtBoxCreditCardBalance;
        private System.Windows.Forms.TextBox txtBoxCreditCardLimit;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxAddressLine2;
        private System.Windows.Forms.TextBox txtBoxAddressLine1;
        private System.Windows.Forms.TextBox txtBoxCreditCardCompany;
        private System.Windows.Forms.TextBox txtBoxCardOwnerName;
        private System.Windows.Forms.TextBox txtBoxCardNumber;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.Label lblCreditCardBalance;
        private System.Windows.Forms.Label lblCreditCardLimit;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.Label lblCardOwnerName;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCreditCardInformation;
        private System.Windows.Forms.GroupBox grBoxButtons;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxMerchantCode;
        private System.Windows.Forms.Label lblMerchantCode;
    }
}