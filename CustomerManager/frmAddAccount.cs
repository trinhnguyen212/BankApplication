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
   

    public partial class frmAddAccount : Form
    {
        /// <summary>
        /// This is the Form to add Account
        /// </summary>
        


        //  Customer customer;
        CustomersController _controller;
       // CustomersController controller = new CustomersController(view, customers);

        public string FirstName
        {
           // get { return this.txtFirstName.Text; }
            set { this.txtName.Text = value; }
        }
        public string ID
        {
         //   get { return this.txtID.Text; }
            set { this.txtID.Text = value; }
        }
        public Customer.StaffStatus IsStaff
        {
            
            set
            {
              this.txtDiscount.Text = value.ToString();
            }
        }
        public frmAddAccount()
        {
            InitializeComponent();
            // customer = cus;
            //  txtName.Text = customer.FirstName;
            // txtDiscount.Text = customer.IsStaff.ToString();
            //txtID.Text = customer.ID;
            //_controller.LoadView1();

        }
        public void SetController(CustomersController controller)
        {
            _controller = controller;
        }

        private void btnAddEverydayAccount_Click(object sender, EventArgs e)
        {
            // customer.AddEverydayAccount();
            _controller.AddEveryDayAccount();
        }


        private void btnAddInvestmentAccount_Click(object sender, EventArgs e)
        {
            //  customer.AddInvestmentAccount();
            _controller.AddInvestmentAccount();


        }

        private void btnAddOmniAccount_Click(object sender, EventArgs e)
        {
            //customer.AddOmniAccount();
            _controller.AddOmniAccount();

        }
    }
}
