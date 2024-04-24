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


    public partial class frmControl : Form
    {
        /// <summary>
        /// This is the MDI container Form (containing 2 forms: frmCatalog & frmLatestAccount) in Observer pattern.
        /// </summary>

        CustomersController _controller;
        
        public frmControl(Customer cus)
        {
            InitializeComponent();
            frmAddAccount frmAdd = new frmAddAccount();

            CustomersController controller1 = new CustomersController(frmAdd, cus);
            controller1.LoadView1();

            frmCatalog frmObsCat = new frmCatalog();
            CustomersController controller2 = new CustomersController(frmObsCat, cus);
            controller2.LoadView2();

            frmLatestAccount frmObsNew = new frmLatestAccount();



            cus.AttachObserver(frmObsCat);
            cus.AttachObserver(frmObsNew);
            
            //code to show forms in the parent form
            frmAdd.MdiParent = this;
            frmObsCat.MdiParent = this;
            frmObsNew.MdiParent = this;


            frmAdd.Show();
            frmObsCat.Show();
            frmObsNew.Show();

          //  frmObsCat.StartPosition = FormStartPosition.CenterScreen;
          //  frmObsNew.StartPosition = FormStartPosition.CenterParent;
         //  frmObsNew.Location = new Point(250, 0);
          //  frmObsCat.Location = new Point(500, 0);
        }
        public void SetController(CustomersController controller)
        {
            _controller = controller;
        }
        private void frmControl_Load(object sender, EventArgs e)
        {
           // cus = this._controller.Customer;

        } 
        
       

        
    }
}
