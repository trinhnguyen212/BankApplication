namespace CustomerManager
{
    partial class InvestmentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnCaculateInterest = new System.Windows.Forms.Button();
            this.btnApplyInterest = new System.Windows.Forms.Button();
            this.txtWithdrawInvestment = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.txtTransferAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Enter Deposit Amount: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1044, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "TRANSACTION HISTORY";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(942, 70);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 579);
            this.listBox1.TabIndex = 34;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.Color.Pink;
            this.btnCheckBalance.Location = new System.Drawing.Point(44, 358);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(188, 73);
            this.btnCheckBalance.TabIndex = 33;
            this.btnCheckBalance.Text = "&Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(551, 662);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 73);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(617, 44);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(248, 31);
            this.txtAmount.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Enter Withdrawal Amount: ";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.DeepPink;
            this.btnWithdraw.Location = new System.Drawing.Point(34, 142);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(188, 73);
            this.btnWithdraw.TabIndex = 27;
            this.btnWithdraw.Text = "&Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDeposit.Location = new System.Drawing.Point(34, 23);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(188, 73);
            this.btnDeposit.TabIndex = 26;
            this.btnDeposit.Text = "&Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnCaculateInterest
            // 
            this.btnCaculateInterest.Location = new System.Drawing.Point(44, 466);
            this.btnCaculateInterest.Margin = new System.Windows.Forms.Padding(6);
            this.btnCaculateInterest.Name = "btnCaculateInterest";
            this.btnCaculateInterest.Size = new System.Drawing.Size(188, 73);
            this.btnCaculateInterest.TabIndex = 39;
            this.btnCaculateInterest.Text = "&Caculate Interest";
            this.btnCaculateInterest.UseVisualStyleBackColor = true;
            this.btnCaculateInterest.Click += new System.EventHandler(this.btnCaculateInterest_Click);
            // 
            // btnApplyInterest
            // 
            this.btnApplyInterest.BackColor = System.Drawing.Color.AliceBlue;
            this.btnApplyInterest.Location = new System.Drawing.Point(44, 569);
            this.btnApplyInterest.Margin = new System.Windows.Forms.Padding(6);
            this.btnApplyInterest.Name = "btnApplyInterest";
            this.btnApplyInterest.Size = new System.Drawing.Size(188, 73);
            this.btnApplyInterest.TabIndex = 42;
            this.btnApplyInterest.Text = "&Apply Interest";
            this.btnApplyInterest.UseVisualStyleBackColor = false;
            this.btnApplyInterest.Click += new System.EventHandler(this.btnApplyInterest_Click);
            // 
            // txtWithdrawInvestment
            // 
            this.txtWithdrawInvestment.Location = new System.Drawing.Point(617, 165);
            this.txtWithdrawInvestment.Margin = new System.Windows.Forms.Padding(6);
            this.txtWithdrawInvestment.Name = "txtWithdrawInvestment";
            this.txtWithdrawInvestment.Size = new System.Drawing.Size(248, 31);
            this.txtWithdrawInvestment.TabIndex = 47;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Aquamarine;
            this.btnTransfer.Location = new System.Drawing.Point(43, 262);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(188, 73);
            this.btnTransfer.TabIndex = 27;
            this.btnTransfer.Text = "&Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Enter Transfer Amount: ";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(624, 237);
            this.txtTransferAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(248, 31);
            this.txtTransferAmount.TabIndex = 47;
            // 
            // txtTransferAccount
            // 
            this.txtTransferAccount.Location = new System.Drawing.Point(623, 313);
            this.txtTransferAccount.Margin = new System.Windows.Forms.Padding(6);
            this.txtTransferAccount.Name = "txtTransferAccount";
            this.txtTransferAccount.Size = new System.Drawing.Size(248, 31);
            this.txtTransferAccount.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "Enter Account to Tranfer: ";
            // 
            // InvestmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.txtTransferAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.txtWithdrawInvestment);
            this.Controls.Add(this.btnApplyInterest);
            this.Controls.Add(this.btnCaculateInterest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InvestmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvestmentAccount";
            this.Load += new System.EventHandler(this.InvestmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnCaculateInterest;
        private System.Windows.Forms.Button btnApplyInterest;
        private System.Windows.Forms.TextBox txtWithdrawInvestment;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.TextBox txtTransferAccount;
        private System.Windows.Forms.Label label4;
    }
}