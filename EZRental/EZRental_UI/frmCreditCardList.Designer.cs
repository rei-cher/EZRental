
namespace EZRental_UI
{
    partial class frmCreditCardList
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
            this.grBoxMain = new System.Windows.Forms.GroupBox();
            this.btnListAllCreditCards = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.grBoxExit = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCreditCardList = new System.Windows.Forms.DataGridView();
            this.cohCreditCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohMerchantCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohAddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohActivationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grBoxMain.SuspendLayout();
            this.grBoxExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "List Credit Card Screen";
            // 
            // grBoxMain
            // 
            this.grBoxMain.Controls.Add(this.dgvCreditCardList);
            this.grBoxMain.Controls.Add(this.btnListAllCreditCards);
            this.grBoxMain.Controls.Add(this.lblMain);
            this.grBoxMain.Location = new System.Drawing.Point(18, 44);
            this.grBoxMain.Name = "grBoxMain";
            this.grBoxMain.Size = new System.Drawing.Size(902, 534);
            this.grBoxMain.TabIndex = 1;
            this.grBoxMain.TabStop = false;
            // 
            // btnListAllCreditCards
            // 
            this.btnListAllCreditCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllCreditCards.Location = new System.Drawing.Point(6, 54);
            this.btnListAllCreditCards.Name = "btnListAllCreditCards";
            this.btnListAllCreditCards.Size = new System.Drawing.Size(176, 31);
            this.btnListAllCreditCards.TabIndex = 1;
            this.btnListAllCreditCards.Text = "List All Credit Cards";
            this.btnListAllCreditCards.UseVisualStyleBackColor = true;
            this.btnListAllCreditCards.Click += new System.EventHandler(this.btnListAllCreditCards_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(2, 16);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(395, 24);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Click List All Button to list all Credit Cards:";
            // 
            // grBoxExit
            // 
            this.grBoxExit.Controls.Add(this.btnExit);
            this.grBoxExit.Location = new System.Drawing.Point(18, 584);
            this.grBoxExit.Name = "grBoxExit";
            this.grBoxExit.Size = new System.Drawing.Size(902, 100);
            this.grBoxExit.TabIndex = 2;
            this.grBoxExit.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(753, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 66);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvCreditCardList
            // 
            this.dgvCreditCardList.AllowUserToAddRows = false;
            this.dgvCreditCardList.AllowUserToDeleteRows = false;
            this.dgvCreditCardList.AllowUserToResizeColumns = false;
            this.dgvCreditCardList.AllowUserToResizeRows = false;
            this.dgvCreditCardList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCreditCardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cohCreditCardNumber,
            this.cohCreditCardOwnerName,
            this.cohCreditCardBank,
            this.cohMerchantCode,
            this.cohExpirationDate,
            this.cohAddressLine1,
            this.cohAddressLine2,
            this.cohCity,
            this.cohState,
            this.cohZipCode,
            this.cohCountry,
            this.cohCreditCardLimit,
            this.cohCreditCardBalance,
            this.cohActivationStatus});
            this.dgvCreditCardList.EnableHeadersVisualStyles = false;
            this.dgvCreditCardList.Location = new System.Drawing.Point(6, 92);
            this.dgvCreditCardList.MultiSelect = false;
            this.dgvCreditCardList.Name = "dgvCreditCardList";
            this.dgvCreditCardList.ReadOnly = true;
            this.dgvCreditCardList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCreditCardList.Size = new System.Drawing.Size(890, 436);
            this.dgvCreditCardList.TabIndex = 2;
            // 
            // cohCreditCardNumber
            // 
            this.cohCreditCardNumber.DataPropertyName = "CreditCardNumber";
            this.cohCreditCardNumber.HeaderText = "Card Number";
            this.cohCreditCardNumber.Name = "cohCreditCardNumber";
            this.cohCreditCardNumber.ReadOnly = true;
            // 
            // cohCreditCardOwnerName
            // 
            this.cohCreditCardOwnerName.DataPropertyName = "CreditCardOwnerName";
            this.cohCreditCardOwnerName.HeaderText = "Owner Name";
            this.cohCreditCardOwnerName.Name = "cohCreditCardOwnerName";
            this.cohCreditCardOwnerName.ReadOnly = true;
            // 
            // cohCreditCardBank
            // 
            this.cohCreditCardBank.DataPropertyName = "CreditCardIssuingCompany";
            this.cohCreditCardBank.HeaderText = "Card Company";
            this.cohCreditCardBank.Name = "cohCreditCardBank";
            this.cohCreditCardBank.ReadOnly = true;
            // 
            // cohMerchantCode
            // 
            this.cohMerchantCode.DataPropertyName = "MerchantCode";
            this.cohMerchantCode.HeaderText = "Merchant Code";
            this.cohMerchantCode.Name = "cohMerchantCode";
            this.cohMerchantCode.ReadOnly = true;
            // 
            // cohExpirationDate
            // 
            this.cohExpirationDate.DataPropertyName = "ExpDate";
            this.cohExpirationDate.HeaderText = "Expiration Date";
            this.cohExpirationDate.Name = "cohExpirationDate";
            this.cohExpirationDate.ReadOnly = true;
            // 
            // cohAddressLine1
            // 
            this.cohAddressLine1.DataPropertyName = "AddressLine1";
            this.cohAddressLine1.HeaderText = "Address Line 1";
            this.cohAddressLine1.Name = "cohAddressLine1";
            this.cohAddressLine1.ReadOnly = true;
            // 
            // cohAddressLine2
            // 
            this.cohAddressLine2.DataPropertyName = "AddressLine2";
            this.cohAddressLine2.HeaderText = "Address Line 2";
            this.cohAddressLine2.Name = "cohAddressLine2";
            this.cohAddressLine2.ReadOnly = true;
            // 
            // cohCity
            // 
            this.cohCity.DataPropertyName = "City";
            this.cohCity.HeaderText = "City";
            this.cohCity.Name = "cohCity";
            this.cohCity.ReadOnly = true;
            // 
            // cohState
            // 
            this.cohState.DataPropertyName = "State";
            this.cohState.HeaderText = "State";
            this.cohState.Name = "cohState";
            this.cohState.ReadOnly = true;
            // 
            // cohZipCode
            // 
            this.cohZipCode.DataPropertyName = "ZipCode";
            this.cohZipCode.HeaderText = "Zip Code";
            this.cohZipCode.Name = "cohZipCode";
            this.cohZipCode.ReadOnly = true;
            // 
            // cohCountry
            // 
            this.cohCountry.DataPropertyName = "Country";
            this.cohCountry.HeaderText = "Country";
            this.cohCountry.Name = "cohCountry";
            this.cohCountry.ReadOnly = true;
            // 
            // cohCreditCardLimit
            // 
            this.cohCreditCardLimit.DataPropertyName = "CreditCardLimit";
            this.cohCreditCardLimit.HeaderText = "Credit Card Limit";
            this.cohCreditCardLimit.Name = "cohCreditCardLimit";
            this.cohCreditCardLimit.ReadOnly = true;
            // 
            // cohCreditCardBalance
            // 
            this.cohCreditCardBalance.DataPropertyName = "CreditCardBalance";
            this.cohCreditCardBalance.HeaderText = "Credit Card Balance";
            this.cohCreditCardBalance.Name = "cohCreditCardBalance";
            this.cohCreditCardBalance.ReadOnly = true;
            // 
            // cohActivationStatus
            // 
            this.cohActivationStatus.DataPropertyName = "ActivationStatus";
            this.cohActivationStatus.HeaderText = "Activation Status";
            this.cohActivationStatus.Name = "cohActivationStatus";
            this.cohActivationStatus.ReadOnly = true;
            // 
            // frmCreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 718);
            this.Controls.Add(this.grBoxExit);
            this.Controls.Add(this.grBoxMain);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreditCardList";
            this.Text = "Credit Card List";
            this.Load += new System.EventHandler(this.frmCreditCardList_Load);
            this.grBoxMain.ResumeLayout(false);
            this.grBoxMain.PerformLayout();
            this.grBoxExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grBoxMain;
        private System.Windows.Forms.Button btnListAllCreditCards;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox grBoxExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCreditCardList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohMerchantCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohActivationStatus;
    }
}