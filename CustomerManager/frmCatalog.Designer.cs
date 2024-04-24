namespace CustomerManager
{
    partial class frmCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalog));
            this.lstCatalog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageTrans = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCatalog
            // 
            resources.ApplyResources(this.lstCatalog, "lstCatalog");
            this.lstCatalog.FormattingEnabled = true;
            this.lstCatalog.Name = "lstCatalog";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnManageTrans
            // 
            resources.ApplyResources(this.btnManageTrans, "btnManageTrans");
            this.btnManageTrans.Name = "btnManageTrans";
            this.btnManageTrans.UseVisualStyleBackColor = true;
            this.btnManageTrans.Click += new System.EventHandler(this.btnManageTrans_Click);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCatalog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnManageTrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCatalog);
            this.MaximizeBox = false;
            this.Name = "frmCatalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lstCatalog;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnManageTrans;
    }
}