
namespace EZRental_UI
{
    partial class frmCreditCardDelete
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
            this.btnApply = new System.Windows.Forms.Button();
            this.txtBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.grBoxButton = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grBoxMain.SuspendLayout();
            this.grBoxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Delete";
            // 
            // grBoxMain
            // 
            this.grBoxMain.Controls.Add(this.btnApply);
            this.grBoxMain.Controls.Add(this.txtBoxCreditCardNumber);
            this.grBoxMain.Controls.Add(this.lblCreditCardNumber);
            this.grBoxMain.Controls.Add(this.lblMain);
            this.grBoxMain.Location = new System.Drawing.Point(19, 48);
            this.grBoxMain.Name = "grBoxMain";
            this.grBoxMain.Size = new System.Drawing.Size(604, 124);
            this.grBoxMain.TabIndex = 1;
            this.grBoxMain.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(479, 68);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(111, 32);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtBoxCreditCardNumber
            // 
            this.txtBoxCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCreditCardNumber.Location = new System.Drawing.Point(213, 71);
            this.txtBoxCreditCardNumber.Name = "txtBoxCreditCardNumber";
            this.txtBoxCreditCardNumber.Size = new System.Drawing.Size(236, 29);
            this.txtBoxCreditCardNumber.TabIndex = 2;
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(11, 73);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(196, 24);
            this.lblCreditCardNumber.TabIndex = 1;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(7, 20);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(512, 24);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Enter Card Number of Credit Card to Delete and Click Apply:";
            // 
            // grBoxButton
            // 
            this.grBoxButton.Controls.Add(this.button1);
            this.grBoxButton.Location = new System.Drawing.Point(19, 221);
            this.grBoxButton.Name = "grBoxButton";
            this.grBoxButton.Size = new System.Drawing.Size(604, 79);
            this.grBoxButton.TabIndex = 2;
            this.grBoxButton.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCreditCardDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 321);
            this.Controls.Add(this.grBoxButton);
            this.Controls.Add(this.grBoxMain);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreditCardDelete";
            this.Text = "Credit Card Delete";
            this.grBoxMain.ResumeLayout(false);
            this.grBoxMain.PerformLayout();
            this.grBoxButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grBoxMain;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtBoxCreditCardNumber;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox grBoxButton;
        private System.Windows.Forms.Button button1;
    }
}