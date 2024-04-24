namespace CustomerManager
{
    partial class InvestmentForm2
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
            this.btnApplyInterest = new System.Windows.Forms.Button();
            this.btnCaculateInterest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnApplyInterest
            // 
            this.btnApplyInterest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnApplyInterest.Location = new System.Drawing.Point(24, 599);
            this.btnApplyInterest.Margin = new System.Windows.Forms.Padding(6);
            this.btnApplyInterest.Name = "btnApplyInterest";
            this.btnApplyInterest.Size = new System.Drawing.Size(188, 73);
            this.btnApplyInterest.TabIndex = 60;
            this.btnApplyInterest.Text = "&Apply Interest";
            this.btnApplyInterest.UseVisualStyleBackColor = false;
            this.btnApplyInterest.UseWaitCursor = true;
            this.btnApplyInterest.Click += new System.EventHandler(this.btnApplyInterest_Click);
            // 
            // btnCaculateInterest
            // 
            this.btnCaculateInterest.BackColor = System.Drawing.Color.DeepPink;
            this.btnCaculateInterest.Location = new System.Drawing.Point(24, 484);
            this.btnCaculateInterest.Margin = new System.Windows.Forms.Padding(6);
            this.btnCaculateInterest.Name = "btnCaculateInterest";
            this.btnCaculateInterest.Size = new System.Drawing.Size(188, 73);
            this.btnCaculateInterest.TabIndex = 57;
            this.btnCaculateInterest.Text = "&Caculate Interest";
            this.btnCaculateInterest.UseVisualStyleBackColor = false;
            this.btnCaculateInterest.UseWaitCursor = true;
            this.btnCaculateInterest.Click += new System.EventHandler(this.btnCaculateInterest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 26);
            this.label2.TabIndex = 54;
            this.label2.Text = "Enter Deposit Amount: ";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(879, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 26);
            this.label1.TabIndex = 53;
            this.label1.Text = "TRANSACTION HISTORY";
            this.label1.UseWaitCursor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(860, 58);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 629);
            this.listBox1.TabIndex = 52;
            this.listBox1.UseWaitCursor = true;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.Color.Orchid;
            this.btnCheckBalance.Location = new System.Drawing.Point(24, 375);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(188, 73);
            this.btnCheckBalance.TabIndex = 51;
            this.btnCheckBalance.Text = "&Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.UseWaitCursor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(439, 614);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 73);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(548, 58);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(248, 31);
            this.txtAmount.TabIndex = 47;
            this.txtAmount.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "Enter Withdrawal Amount: ";
            this.label5.UseWaitCursor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Brown;
            this.btnWithdraw.Location = new System.Drawing.Point(24, 130);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(188, 73);
            this.btnWithdraw.TabIndex = 45;
            this.btnWithdraw.Text = "&Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.UseWaitCursor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDeposit.Location = new System.Drawing.Point(24, 37);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(188, 73);
            this.btnDeposit.TabIndex = 44;
            this.btnDeposit.Text = "&Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.UseWaitCursor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(548, 151);
            this.txtWithdrawAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(248, 31);
            this.txtWithdrawAmount.TabIndex = 47;
            this.txtWithdrawAmount.UseWaitCursor = true;
            // 
            // InvestmentForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1588, 865);
            this.Controls.Add(this.btnApplyInterest);
            this.Controls.Add(this.btnCaculateInterest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InvestmentForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvestmentForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApplyInterest;
        private System.Windows.Forms.Button btnCaculateInterest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
    }
}