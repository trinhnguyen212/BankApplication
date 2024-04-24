using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManager
{

    [Serializable]
    public partial class frmCatalog : Form, IObserver
    {
        /// <summary>
        /// This is the frmCatalog to implement Observer pattern.
        /// </summary>
        
        CustomersController _controller;

        public frmCatalog()
        {
            InitializeComponent();
            //foreach (BankAccounts bankAccounts in cus.GetSetAccountType)
            //{
            //    lstCatalog.Items.Add(bankAccounts.Info());
            //}
        }
        public void SetController(CustomersController controller)
        {
            _controller = controller;
        }

        public void Update(BankAccounts p)
        {
            lstCatalog.Items.Add(p.Info());
        }

        private void btnManageTrans_Click(object sender, EventArgs e)
        {
            _controller.ManageSelectedAccount();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            _controller.LoadView2();
        }
    }
}
