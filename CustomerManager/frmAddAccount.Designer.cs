namespace CustomerManager
{
    partial class frmAddAccount
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
            this.btnAddSavingAccount = new System.Windows.Forms.Button();
            this.btnAddEverydayAccount = new System.Windows.Forms.Button();
            this.btnAddOmniAccount = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSavingAccount
            // 
            this.btnAddSavingAccount.Location = new System.Drawing.Point(667, 295);
            this.btnAddSavingAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddSavingAccount.Name = "btnAddSavingAccount";
            this.btnAddSavingAccount.Size = new System.Drawing.Size(286, 102);
            this.btnAddSavingAccount.TabIndex = 0;
            this.btnAddSavingAccount.Text = "Add InvestmentAccount";
            this.btnAddSavingAccount.UseVisualStyleBackColor = true;
            this.btnAddSavingAccount.Click += new System.EventHandler(this.btnAddInvestmentAccount_Click);
            // 
            // btnAddEverydayAccount
            // 
            this.btnAddEverydayAccount.Location = new System.Drawing.Point(354, 295);
            this.btnAddEverydayAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddEverydayAccount.Name = "btnAddEverydayAccount";
            this.btnAddEverydayAccount.Size = new System.Drawing.Size(286, 102);
            this.btnAddEverydayAccount.TabIndex = 1;
            this.btnAddEverydayAccount.Text = "Add EverydayAccount";
            this.btnAddEverydayAccount.UseVisualStyleBackColor = true;
            this.btnAddEverydayAccount.Click += new System.EventHandler(this.btnAddEverydayAccount_Click);
            // 
            // btnAddOmniAccount
            // 
            this.btnAddOmniAccount.Location = new System.Drawing.Point(15, 295);
            this.btnAddOmniAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddOmniAccount.Name = "btnAddOmniAccount";
            this.btnAddOmniAccount.Size = new System.Drawing.Size(286, 102);
            this.btnAddOmniAccount.TabIndex = 2;
            this.btnAddOmniAccount.Text = "Add OmniAccount";
            this.btnAddOmniAccount.UseVisualStyleBackColor = true;
            this.btnAddOmniAccount.Click += new System.EventHandler(this.btnAddOmniAccount_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(411, 91);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 31);
            this.txtDiscount.TabIndex = 25;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(213, 86);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(150, 37);
            this.lblDiscount.TabIndex = 23;
            this.lblDiscount.Text = "&Discount";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(411, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 26;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(213, 45);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(107, 37);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "&Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(414, 155);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 31);
            this.txtID.TabIndex = 28;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "&ID";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 423);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddOmniAccount);
            this.Controls.Add(this.btnAddEverydayAccount);
            this.Controls.Add(this.btnAddSavingAccount);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddAccount";
            this.Text = "frmAddAccounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSavingAccount;
        private System.Windows.Forms.Button btnAddEverydayAccount;
        private System.Windows.Forms.Button btnAddOmniAccount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}