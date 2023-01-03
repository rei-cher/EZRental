
namespace EZRental_UI
{
    partial class frmMainWelcomeForm
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
            this.btnPos = new System.Windows.Forms.Button();
            this.btnERP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(176, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "EZRental POS System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnPos
            // 
            this.btnPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.Location = new System.Drawing.Point(117, 107);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(417, 35);
            this.btnPos.TabIndex = 1;
            this.btnPos.Text = "Point-of-Sale and Rentals (Coming Soon)\r\n";
            this.btnPos.UseVisualStyleBackColor = true;
            // 
            // btnERP
            // 
            this.btnERP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERP.Location = new System.Drawing.Point(117, 165);
            this.btnERP.Name = "btnERP";
            this.btnERP.Size = new System.Drawing.Size(417, 35);
            this.btnERP.TabIndex = 2;
            this.btnERP.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.btnERP.UseVisualStyleBackColor = true;
            this.btnERP.Click += new System.EventHandler(this.btnERP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(238, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 345);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnERP);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMainWelcomeForm";
            this.Text = "EZRental POS System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnERP;
        private System.Windows.Forms.Button btnExit;
    }
}

