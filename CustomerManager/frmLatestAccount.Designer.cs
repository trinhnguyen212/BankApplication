namespace CustomerManager
{
    partial class frmLatestAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLatestBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest Added Account";
            // 
            // lblLatestBook
            // 
            this.lblLatestBook.AutoSize = true;
            this.lblLatestBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatestBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestBook.Location = new System.Drawing.Point(25, 146);
            this.lblLatestBook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLatestBook.MinimumSize = new System.Drawing.Size(400, 50);
            this.lblLatestBook.Name = "lblLatestBook";
            this.lblLatestBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLatestBook.Size = new System.Drawing.Size(400, 50);
            this.lblLatestBook.TabIndex = 1;
            this.lblLatestBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLatestAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(514, 581);
            this.Controls.Add(this.lblLatestBook);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLatestAccount";
            this.Text = "frmObservorNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLatestBook;
    }
}