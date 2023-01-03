
namespace EZRental_UI
{
    partial class frmCreditCardSearch
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
            this.grBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.grBoxInformation = new System.Windows.Forms.GroupBox();
            this.txtBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.txtBoxActivationStatus = new System.Windows.Forms.TextBox();
            this.txtBoxCreditCardBalance = new System.Windows.Forms.TextBox();
            this.txtBoxCreditCardLimit = new System.Windows.Forms.TextBox();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtBoxAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtBoxCreditCardCompany = new System.Windows.Forms.TextBox();
            this.txtBoxCardOwnerName = new System.Windows.Forms.TextBox();
            this.txtBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.lblCreditCardBalance = new System.Windows.Forms.Label();
            this.lblCreditCardLimit = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.lblCardOwnerName = new System.Windows.Forms.Label();
            this.grBoxPrintInformation = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grBoxExit = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMerchantCode = new System.Windows.Forms.Label();
            this.txtBoxMerchantCode = new System.Windows.Forms.TextBox();
            this.grBoxSearch.SuspendLayout();
            this.grBoxInformation.SuspendLayout();
            this.grBoxPrintInformation.SuspendLayout();
            this.grBoxExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Search";
            // 
            // grBoxSearch
            // 
            this.grBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.grBoxSearch.Controls.Add(this.btnSearch);
            this.grBoxSearch.Controls.Add(this.txtBoxCardNumber);
            this.grBoxSearch.Controls.Add(this.lblCardNumber);
            this.grBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxSearch.Location = new System.Drawing.Point(12, 53);
            this.grBoxSearch.Name = "grBoxSearch";
            this.grBoxSearch.Size = new System.Drawing.Size(776, 88);
            this.grBoxSearch.TabIndex = 1;
            this.grBoxSearch.TabStop = false;
            this.grBoxSearch.Text = "Enter Credit Card Number and Click Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(418, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxCardNumber
            // 
            this.txtBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCardNumber.Location = new System.Drawing.Point(153, 40);
            this.txtBoxCardNumber.Name = "txtBoxCardNumber";
            this.txtBoxCardNumber.Size = new System.Drawing.Size(219, 29);
            this.txtBoxCardNumber.TabIndex = 1;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(6, 40);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(141, 24);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // grBoxInformation
            // 
            this.grBoxInformation.Controls.Add(this.txtBoxMerchantCode);
            this.grBoxInformation.Controls.Add(this.lblMerchantCode);
            this.grBoxInformation.Controls.Add(this.txtBoxExpirationDate);
            this.grBoxInformation.Controls.Add(this.txtBoxActivationStatus);
            this.grBoxInformation.Controls.Add(this.txtBoxCreditCardBalance);
            this.grBoxInformation.Controls.Add(this.txtBoxCreditCardLimit);
            this.grBoxInformation.Controls.Add(this.txtBoxCountry);
            this.grBoxInformation.Controls.Add(this.txtBoxZipCode);
            this.grBoxInformation.Controls.Add(this.txtBoxState);
            this.grBoxInformation.Controls.Add(this.txtBoxCity);
            this.grBoxInformation.Controls.Add(this.txtBoxAddressLine2);
            this.grBoxInformation.Controls.Add(this.txtBoxAddressLine1);
            this.grBoxInformation.Controls.Add(this.txtBoxCreditCardCompany);
            this.grBoxInformation.Controls.Add(this.txtBoxCardOwnerName);
            this.grBoxInformation.Controls.Add(this.txtBoxCreditCardNumber);
            this.grBoxInformation.Controls.Add(this.lblActivationStatus);
            this.grBoxInformation.Controls.Add(this.lblCreditCardBalance);
            this.grBoxInformation.Controls.Add(this.lblCreditCardLimit);
            this.grBoxInformation.Controls.Add(this.lblCountry);
            this.grBoxInformation.Controls.Add(this.lblZipCode);
            this.grBoxInformation.Controls.Add(this.lblCreditCardNumber);
            this.grBoxInformation.Controls.Add(this.lblState);
            this.grBoxInformation.Controls.Add(this.lblCity);
            this.grBoxInformation.Controls.Add(this.lblAddressLine2);
            this.grBoxInformation.Controls.Add(this.lblAddressLine1);
            this.grBoxInformation.Controls.Add(this.lblExpirationDate);
            this.grBoxInformation.Controls.Add(this.lblCreditCardCompany);
            this.grBoxInformation.Controls.Add(this.lblCardOwnerName);
            this.grBoxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxInformation.Location = new System.Drawing.Point(12, 148);
            this.grBoxInformation.Name = "grBoxInformation";
            this.grBoxInformation.Size = new System.Drawing.Size(422, 608);
            this.grBoxInformation.TabIndex = 2;
            this.grBoxInformation.TabStop = false;
            this.grBoxInformation.Text = "Credit Card Information:";
            // 
            // txtBoxExpirationDate
            // 
            this.txtBoxExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExpirationDate.Location = new System.Drawing.Point(209, 195);
            this.txtBoxExpirationDate.Name = "txtBoxExpirationDate";
            this.txtBoxExpirationDate.ReadOnly = true;
            this.txtBoxExpirationDate.Size = new System.Drawing.Size(205, 29);
            this.txtBoxExpirationDate.TabIndex = 27;
            // 
            // txtBoxActivationStatus
            // 
            this.txtBoxActivationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxActivationStatus.Location = new System.Drawing.Point(209, 505);
            this.txtBoxActivationStatus.Name = "txtBoxActivationStatus";
            this.txtBoxActivationStatus.ReadOnly = true;
            this.txtBoxActivationStatus.Size = new System.Drawing.Size(205, 29);
            this.txtBoxActivationStatus.TabIndex = 26;
            // 
            // txtBoxCreditCardBalance
            // 
            this.txtBoxCreditCardBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardBalance.Location = new System.Drawing.Point(209, 471);
            this.txtBoxCreditCardBalance.Name = "txtBoxCreditCardBalance";
            this.txtBoxCreditCardBalance.ReadOnly = true;
            this.txtBoxCreditCardBalance.Size = new System.Drawing.Size(205, 29);
            this.txtBoxCreditCardBalance.TabIndex = 25;
            // 
            // txtBoxCreditCardLimit
            // 
            this.txtBoxCreditCardLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardLimit.Location = new System.Drawing.Point(209, 437);
            this.txtBoxCreditCardLimit.Name = "txtBoxCreditCardLimit";
            this.txtBoxCreditCardLimit.ReadOnly = true;
            this.txtBoxCreditCardLimit.Size = new System.Drawing.Size(205, 29);
            this.txtBoxCreditCardLimit.TabIndex = 24;
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCountry.Location = new System.Drawing.Point(209, 403);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.ReadOnly = true;
            this.txtBoxCountry.Size = new System.Drawing.Size(205, 29);
            this.txtBoxCountry.TabIndex = 23;
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZipCode.Location = new System.Drawing.Point(209, 369);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.ReadOnly = true;
            this.txtBoxZipCode.Size = new System.Drawing.Size(205, 29);
            this.txtBoxZipCode.TabIndex = 22;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxState.Location = new System.Drawing.Point(209, 331);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.ReadOnly = true;
            this.txtBoxState.Size = new System.Drawing.Size(205, 29);
            this.txtBoxState.TabIndex = 21;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(209, 297);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.ReadOnly = true;
            this.txtBoxCity.Size = new System.Drawing.Size(205, 29);
            this.txtBoxCity.TabIndex = 20;
            // 
            // txtBoxAddressLine2
            // 
            this.txtBoxAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddressLine2.Location = new System.Drawing.Point(209, 263);
            this.txtBoxAddressLine2.Name = "txtBoxAddressLine2";
            this.txtBoxAddressLine2.ReadOnly = true;
            this.txtBoxAddressLine2.Size = new System.Drawing.Size(205, 29);
            this.txtBoxAddressLine2.TabIndex = 19;
            // 
            // txtBoxAddressLine1
            // 
            this.txtBoxAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddressLine1.Location = new System.Drawing.Point(209, 229);
            this.txtBoxAddressLine1.Name = "txtBoxAddressLine1";
            this.txtBoxAddressLine1.ReadOnly = true;
            this.txtBoxAddressLine1.Size = new System.Drawing.Size(205, 29);
            this.txtBoxAddressLine1.TabIndex = 18;
            // 
            // txtBoxCreditCardCompany
            // 
            this.txtBoxCreditCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardCompany.Location = new System.Drawing.Point(209, 127);
            this.txtBoxCreditCardCompany.Name = "txtBoxCreditCardCompany";
            this.txtBoxCreditCardCompany.ReadOnly = true;
            this.txtBoxCreditCardCompany.Size = new System.Drawing.Size(205, 29);
            this.txtBoxCreditCardCompany.TabIndex = 17;
            // 
            // txtBoxCardOwnerName
            // 
            this.txtBoxCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCardOwnerName.Location = new System.Drawing.Point(209, 93);
            this.txtBoxCardOwnerName.Name = "txtBoxCardOwnerName";
            this.txtBoxCardOwnerName.ReadOnly = true;
            this.txtBoxCardOwnerName.Size = new System.Drawing.Size(205, 29);
            this.txtBoxCardOwnerName.TabIndex = 15;
            // 
            // txtBoxCreditCardNumber
            // 
            this.txtBoxCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardNumber.Location = new System.Drawing.Point(209, 62);
            this.txtBoxCreditCardNumber.Name = "txtBoxCreditCardNumber";
            this.txtBoxCreditCardNumber.ReadOnly = true;
            this.txtBoxCreditCardNumber.Size = new System.Drawing.Size(205, 29);
            this.txtBoxCreditCardNumber.TabIndex = 14;
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivationStatus.Location = new System.Drawing.Point(6, 508);
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
            this.lblCreditCardBalance.Location = new System.Drawing.Point(6, 474);
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
            this.lblCreditCardLimit.Location = new System.Drawing.Point(6, 440);
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
            this.lblCountry.Location = new System.Drawing.Point(6, 406);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCountry.Size = new System.Drawing.Size(75, 34);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country";
            this.lblCountry.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(6, 372);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblZipCode.Size = new System.Drawing.Size(88, 34);
            this.lblZipCode.TabIndex = 9;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(6, 62);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardNumber.Size = new System.Drawing.Size(196, 34);
            this.lblCreditCardNumber.TabIndex = 8;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(6, 334);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblState.Size = new System.Drawing.Size(51, 34);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 300);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 24);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(6, 266);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAddressLine2.Size = new System.Drawing.Size(136, 34);
            this.lblAddressLine2.TabIndex = 5;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(6, 232);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAddressLine1.Size = new System.Drawing.Size(136, 34);
            this.lblAddressLine1.TabIndex = 4;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(6, 198);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblExpirationDate.Size = new System.Drawing.Size(137, 34);
            this.lblExpirationDate.TabIndex = 3;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardCompany.Location = new System.Drawing.Point(6, 130);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardCompany.Size = new System.Drawing.Size(190, 34);
            this.lblCreditCardCompany.TabIndex = 2;
            this.lblCreditCardCompany.Text = "Credit Card Company";
            // 
            // lblCardOwnerName
            // 
            this.lblCardOwnerName.AutoSize = true;
            this.lblCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardOwnerName.Location = new System.Drawing.Point(6, 96);
            this.lblCardOwnerName.Name = "lblCardOwnerName";
            this.lblCardOwnerName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCardOwnerName.Size = new System.Drawing.Size(168, 34);
            this.lblCardOwnerName.TabIndex = 0;
            this.lblCardOwnerName.Text = "Card Owner Name";
            // 
            // grBoxPrintInformation
            // 
            this.grBoxPrintInformation.Controls.Add(this.btnPrint);
            this.grBoxPrintInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxPrintInformation.Location = new System.Drawing.Point(449, 148);
            this.grBoxPrintInformation.Name = "grBoxPrintInformation";
            this.grBoxPrintInformation.Size = new System.Drawing.Size(339, 608);
            this.grBoxPrintInformation.TabIndex = 3;
            this.grBoxPrintInformation.TabStop = false;
            this.grBoxPrintInformation.Text = "Print Credit Card Information:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(103, 62);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 34);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grBoxExit
            // 
            this.grBoxExit.Controls.Add(this.btnExit);
            this.grBoxExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxExit.Location = new System.Drawing.Point(12, 762);
            this.grBoxExit.Name = "grBoxExit";
            this.grBoxExit.Size = new System.Drawing.Size(780, 89);
            this.grBoxExit.TabIndex = 4;
            this.grBoxExit.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(540, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMerchantCode
            // 
            this.lblMerchantCode.AutoSize = true;
            this.lblMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantCode.Location = new System.Drawing.Point(6, 164);
            this.lblMerchantCode.Name = "lblMerchantCode";
            this.lblMerchantCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblMerchantCode.Size = new System.Drawing.Size(135, 34);
            this.lblMerchantCode.TabIndex = 28;
            this.lblMerchantCode.Text = "MerchantCode";
            // 
            // txtBoxMerchantCode
            // 
            this.txtBoxMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMerchantCode.Location = new System.Drawing.Point(209, 161);
            this.txtBoxMerchantCode.Name = "txtBoxMerchantCode";
            this.txtBoxMerchantCode.ReadOnly = true;
            this.txtBoxMerchantCode.Size = new System.Drawing.Size(205, 29);
            this.txtBoxMerchantCode.TabIndex = 29;
            // 
            // frmCreditCardSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 863);
            this.Controls.Add(this.grBoxExit);
            this.Controls.Add(this.grBoxPrintInformation);
            this.Controls.Add(this.grBoxInformation);
            this.Controls.Add(this.grBoxSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreditCardSearch";
            this.Text = "Credot Card Search";
            this.grBoxSearch.ResumeLayout(false);
            this.grBoxSearch.PerformLayout();
            this.grBoxInformation.ResumeLayout(false);
            this.grBoxInformation.PerformLayout();
            this.grBoxPrintInformation.ResumeLayout(false);
            this.grBoxExit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.GroupBox grBoxInformation;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.Label lblCreditCardBalance;
        private System.Windows.Forms.Label lblCreditCardLimit;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.Label lblCardOwnerName;
        private System.Windows.Forms.TextBox txtBoxExpirationDate;
        private System.Windows.Forms.TextBox txtBoxActivationStatus;
        private System.Windows.Forms.TextBox txtBoxCreditCardBalance;
        private System.Windows.Forms.TextBox txtBoxCreditCardLimit;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxAddressLine2;
        private System.Windows.Forms.TextBox txtBoxAddressLine1;
        private System.Windows.Forms.TextBox txtBoxCreditCardCompany;
        private System.Windows.Forms.TextBox txtBoxCardOwnerName;
        private System.Windows.Forms.TextBox txtBoxCreditCardNumber;
        private System.Windows.Forms.GroupBox grBoxPrintInformation;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grBoxExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxMerchantCode;
        private System.Windows.Forms.Label lblMerchantCode;
    }
}