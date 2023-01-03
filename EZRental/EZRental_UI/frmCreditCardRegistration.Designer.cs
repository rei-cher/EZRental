
namespace EZRental_UI
{
    partial class frmCreditCardRegistration
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
            this.grBoxRegistration = new System.Windows.Forms.GroupBox();
            this.cmbBoxActivate = new System.Windows.Forms.ComboBox();
            this.cmbBoxCountry = new System.Windows.Forms.ComboBox();
            this.cmbBoxState = new System.Windows.Forms.ComboBox();
            this.dateTimeExpiration = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCreditCardBalance = new System.Windows.Forms.TextBox();
            this.txtBoxCreditCardLimit = new System.Windows.Forms.TextBox();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
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
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.lblCardOwnerName = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.grBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblMerchantCode = new System.Windows.Forms.Label();
            this.txtBoxMerchantCode = new System.Windows.Forms.TextBox();
            this.grBoxRegistration.SuspendLayout();
            this.grBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Registration";
            // 
            // grBoxRegistration
            // 
            this.grBoxRegistration.Controls.Add(this.txtBoxMerchantCode);
            this.grBoxRegistration.Controls.Add(this.lblMerchantCode);
            this.grBoxRegistration.Controls.Add(this.cmbBoxActivate);
            this.grBoxRegistration.Controls.Add(this.cmbBoxCountry);
            this.grBoxRegistration.Controls.Add(this.cmbBoxState);
            this.grBoxRegistration.Controls.Add(this.dateTimeExpiration);
            this.grBoxRegistration.Controls.Add(this.txtBoxCreditCardBalance);
            this.grBoxRegistration.Controls.Add(this.txtBoxCreditCardLimit);
            this.grBoxRegistration.Controls.Add(this.txtBoxZipCode);
            this.grBoxRegistration.Controls.Add(this.txtBoxCity);
            this.grBoxRegistration.Controls.Add(this.txtBoxAddressLine2);
            this.grBoxRegistration.Controls.Add(this.txtBoxAddressLine1);
            this.grBoxRegistration.Controls.Add(this.txtBoxCreditCardCompany);
            this.grBoxRegistration.Controls.Add(this.txtBoxCardOwnerName);
            this.grBoxRegistration.Controls.Add(this.txtBoxCreditCardNumber);
            this.grBoxRegistration.Controls.Add(this.lblActivationStatus);
            this.grBoxRegistration.Controls.Add(this.lblCreditCardBalance);
            this.grBoxRegistration.Controls.Add(this.lblCreditCardLimit);
            this.grBoxRegistration.Controls.Add(this.lblCountry);
            this.grBoxRegistration.Controls.Add(this.lblZipCode);
            this.grBoxRegistration.Controls.Add(this.lblState);
            this.grBoxRegistration.Controls.Add(this.lblCity);
            this.grBoxRegistration.Controls.Add(this.lblAddressLine2);
            this.grBoxRegistration.Controls.Add(this.lblAddressLine1);
            this.grBoxRegistration.Controls.Add(this.lblExpirationDate);
            this.grBoxRegistration.Controls.Add(this.lblCreditCardCompany);
            this.grBoxRegistration.Controls.Add(this.lblCardOwnerName);
            this.grBoxRegistration.Controls.Add(this.lblCreditCardNumber);
            this.grBoxRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxRegistration.Location = new System.Drawing.Point(18, 71);
            this.grBoxRegistration.Name = "grBoxRegistration";
            this.grBoxRegistration.Size = new System.Drawing.Size(492, 575);
            this.grBoxRegistration.TabIndex = 1;
            this.grBoxRegistration.TabStop = false;
            this.grBoxRegistration.Text = "Enter Credit Card Information:";
            // 
            // cmbBoxActivate
            // 
            this.cmbBoxActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxActivate.FormattingEnabled = true;
            this.cmbBoxActivate.Location = new System.Drawing.Point(244, 497);
            this.cmbBoxActivate.Name = "cmbBoxActivate";
            this.cmbBoxActivate.Size = new System.Drawing.Size(230, 32);
            this.cmbBoxActivate.TabIndex = 29;
            // 
            // cmbBoxCountry
            // 
            this.cmbBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxCountry.FormattingEnabled = true;
            this.cmbBoxCountry.Location = new System.Drawing.Point(244, 395);
            this.cmbBoxCountry.Name = "cmbBoxCountry";
            this.cmbBoxCountry.Size = new System.Drawing.Size(230, 32);
            this.cmbBoxCountry.TabIndex = 28;
            // 
            // cmbBoxState
            // 
            this.cmbBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxState.FormattingEnabled = true;
            this.cmbBoxState.Location = new System.Drawing.Point(244, 327);
            this.cmbBoxState.Name = "cmbBoxState";
            this.cmbBoxState.Size = new System.Drawing.Size(230, 32);
            this.cmbBoxState.TabIndex = 27;
            // 
            // dateTimeExpiration
            // 
            this.dateTimeExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpiration.Location = new System.Drawing.Point(244, 190);
            this.dateTimeExpiration.Name = "dateTimeExpiration";
            this.dateTimeExpiration.Size = new System.Drawing.Size(230, 29);
            this.dateTimeExpiration.TabIndex = 26;
            // 
            // txtBoxCreditCardBalance
            // 
            this.txtBoxCreditCardBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardBalance.Location = new System.Drawing.Point(244, 463);
            this.txtBoxCreditCardBalance.Name = "txtBoxCreditCardBalance";
            this.txtBoxCreditCardBalance.Size = new System.Drawing.Size(230, 29);
            this.txtBoxCreditCardBalance.TabIndex = 24;
            // 
            // txtBoxCreditCardLimit
            // 
            this.txtBoxCreditCardLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardLimit.Location = new System.Drawing.Point(244, 429);
            this.txtBoxCreditCardLimit.Name = "txtBoxCreditCardLimit";
            this.txtBoxCreditCardLimit.Size = new System.Drawing.Size(230, 29);
            this.txtBoxCreditCardLimit.TabIndex = 23;
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZipCode.Location = new System.Drawing.Point(244, 361);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(230, 29);
            this.txtBoxZipCode.TabIndex = 21;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(244, 293);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(230, 29);
            this.txtBoxCity.TabIndex = 19;
            // 
            // txtBoxAddressLine2
            // 
            this.txtBoxAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddressLine2.Location = new System.Drawing.Point(244, 259);
            this.txtBoxAddressLine2.Name = "txtBoxAddressLine2";
            this.txtBoxAddressLine2.Size = new System.Drawing.Size(230, 29);
            this.txtBoxAddressLine2.TabIndex = 18;
            // 
            // txtBoxAddressLine1
            // 
            this.txtBoxAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddressLine1.Location = new System.Drawing.Point(244, 225);
            this.txtBoxAddressLine1.Name = "txtBoxAddressLine1";
            this.txtBoxAddressLine1.Size = new System.Drawing.Size(230, 29);
            this.txtBoxAddressLine1.TabIndex = 17;
            // 
            // txtBoxCreditCardCompany
            // 
            this.txtBoxCreditCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardCompany.Location = new System.Drawing.Point(244, 123);
            this.txtBoxCreditCardCompany.Name = "txtBoxCreditCardCompany";
            this.txtBoxCreditCardCompany.Size = new System.Drawing.Size(230, 29);
            this.txtBoxCreditCardCompany.TabIndex = 15;
            // 
            // txtBoxCardOwnerName
            // 
            this.txtBoxCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCardOwnerName.Location = new System.Drawing.Point(244, 89);
            this.txtBoxCardOwnerName.Name = "txtBoxCardOwnerName";
            this.txtBoxCardOwnerName.Size = new System.Drawing.Size(230, 29);
            this.txtBoxCardOwnerName.TabIndex = 14;
            // 
            // txtBoxCreditCardNumber
            // 
            this.txtBoxCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardNumber.Location = new System.Drawing.Point(244, 55);
            this.txtBoxCreditCardNumber.Name = "txtBoxCreditCardNumber";
            this.txtBoxCreditCardNumber.Size = new System.Drawing.Size(230, 29);
            this.txtBoxCreditCardNumber.TabIndex = 13;
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivationStatus.Location = new System.Drawing.Point(7, 500);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblActivationStatus.Size = new System.Drawing.Size(145, 34);
            this.lblActivationStatus.TabIndex = 12;
            this.lblActivationStatus.Text = "Activation Status";
            // 
            // lblCreditCardBalance
            // 
            this.lblCreditCardBalance.AutoSize = true;
            this.lblCreditCardBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardBalance.Location = new System.Drawing.Point(7, 466);
            this.lblCreditCardBalance.Name = "lblCreditCardBalance";
            this.lblCreditCardBalance.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardBalance.Size = new System.Drawing.Size(177, 34);
            this.lblCreditCardBalance.TabIndex = 11;
            this.lblCreditCardBalance.Text = "Credit Card Balance";
            // 
            // lblCreditCardLimit
            // 
            this.lblCreditCardLimit.AutoSize = true;
            this.lblCreditCardLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardLimit.Location = new System.Drawing.Point(7, 432);
            this.lblCreditCardLimit.Name = "lblCreditCardLimit";
            this.lblCreditCardLimit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardLimit.Size = new System.Drawing.Size(147, 34);
            this.lblCreditCardLimit.TabIndex = 10;
            this.lblCreditCardLimit.Text = "Credit Card Limit";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(7, 398);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCountry.Size = new System.Drawing.Size(75, 34);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(7, 364);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblZipCode.Size = new System.Drawing.Size(88, 34);
            this.lblZipCode.TabIndex = 8;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(7, 330);
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
            this.lblCity.Location = new System.Drawing.Point(7, 296);
            this.lblCity.Name = "lblCity";
            this.lblCity.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCity.Size = new System.Drawing.Size(40, 34);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(7, 262);
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
            this.lblAddressLine1.Location = new System.Drawing.Point(7, 228);
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
            this.lblExpirationDate.Location = new System.Drawing.Point(7, 194);
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
            this.lblCreditCardCompany.Location = new System.Drawing.Point(6, 126);
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
            this.lblCardOwnerName.Location = new System.Drawing.Point(7, 92);
            this.lblCardOwnerName.Name = "lblCardOwnerName";
            this.lblCardOwnerName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCardOwnerName.Size = new System.Drawing.Size(168, 34);
            this.lblCardOwnerName.TabIndex = 1;
            this.lblCardOwnerName.Text = "Card Owner Name";
            this.lblCardOwnerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(7, 58);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCreditCardNumber.Size = new System.Drawing.Size(196, 34);
            this.lblCreditCardNumber.TabIndex = 0;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // grBoxButtons
            // 
            this.grBoxButtons.Controls.Add(this.btnExit);
            this.grBoxButtons.Controls.Add(this.btnApply);
            this.grBoxButtons.Location = new System.Drawing.Point(18, 652);
            this.grBoxButtons.Name = "grBoxButtons";
            this.grBoxButtons.Size = new System.Drawing.Size(492, 109);
            this.grBoxButtons.TabIndex = 2;
            this.grBoxButtons.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(244, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(373, 35);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(101, 41);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblMerchantCode
            // 
            this.lblMerchantCode.AutoSize = true;
            this.lblMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantCode.Location = new System.Drawing.Point(7, 160);
            this.lblMerchantCode.Name = "lblMerchantCode";
            this.lblMerchantCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblMerchantCode.Size = new System.Drawing.Size(140, 34);
            this.lblMerchantCode.TabIndex = 30;
            this.lblMerchantCode.Text = "Merchant Code";
            // 
            // txtBoxMerchantCode
            // 
            this.txtBoxMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMerchantCode.Location = new System.Drawing.Point(244, 157);
            this.txtBoxMerchantCode.Name = "txtBoxMerchantCode";
            this.txtBoxMerchantCode.Size = new System.Drawing.Size(230, 29);
            this.txtBoxMerchantCode.TabIndex = 31;
            // 
            // frmCreditCardRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 773);
            this.Controls.Add(this.grBoxButtons);
            this.Controls.Add(this.grBoxRegistration);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreditCardRegistration";
            this.Text = "Credit Card Registration";
            this.Load += new System.EventHandler(this.frmCreditCardRegistration_Load_1);
            this.grBoxRegistration.ResumeLayout(false);
            this.grBoxRegistration.PerformLayout();
            this.grBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grBoxRegistration;
        private System.Windows.Forms.Label lblCardOwnerName;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.ComboBox cmbBoxCountry;
        private System.Windows.Forms.ComboBox cmbBoxState;
        private System.Windows.Forms.DateTimePicker dateTimeExpiration;
        private System.Windows.Forms.TextBox txtBoxCreditCardBalance;
        private System.Windows.Forms.TextBox txtBoxCreditCardLimit;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxAddressLine2;
        private System.Windows.Forms.TextBox txtBoxAddressLine1;
        private System.Windows.Forms.TextBox txtBoxCreditCardCompany;
        private System.Windows.Forms.TextBox txtBoxCardOwnerName;
        private System.Windows.Forms.TextBox txtBoxCreditCardNumber;
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
        private System.Windows.Forms.GroupBox grBoxButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbBoxActivate;
        private System.Windows.Forms.TextBox txtBoxMerchantCode;
        private System.Windows.Forms.Label lblMerchantCode;
    }
}