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


    public partial class frmLatestAccount : Form, IObserver
    {
        /// <summary>
        /// This is the frmLatestAccount to implement Observer pattern.
        /// </summary>

        CustomersController _controller;

        public frmLatestAccount()
        {
            InitializeComponent();
        }
        public void Update(BankAccounts p)
        {
            lblLatestBook.Text = p.Info();
        }
        public void SetController(CustomersController controller)
        {
            _controller = controller;
        }
    }
}
