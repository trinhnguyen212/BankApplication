using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class BankForm : Form
    {
       List<BankAccounts> List = new List<BankAccounts>();
      Customer customer1 = new Customer();
        OmniAccounts a =  new OmniAccounts(0.05m, 100, 20, 100);
        EverydayAccount b = new EverydayAccount(140000);
        InvestmentAccounts c = new InvestmentAccounts(0.03m, 20, 5000);
        public BankForm(Customer customer)
        {
            InitializeComponent();
            this.customer1 = customer;
            List.Add(a);
            List.Add(b);
            List.Add(c);
            customer1.GetSetAccountType = List;
            PopulateComboBox();
        

            txtName.Text = customer.Name;
            if (customer.IsStaff)
            {
                txtDiscount.Text = "Applicable";
            }
            else { txtDiscount.Text = "Unapplicable"; }
            
             txtEmail.Text = customer.Email;
            txtName.Enabled = false;
           txtEmail.Enabled = false;
           txtDiscount.Enabled = false;            
        }       
        private void btnApply_Click(object sender, EventArgs e)
        {

            if(comboBox1.Text== "EverydayAccount") 
            {
            
                EverydayForm1 frm1 = new EverydayForm1(customer1, b);
                frm1.Show();
            }
            if(comboBox1.Text == "InvestmentAccounts") 
            {
               
                InvestmentForm2 frm2 = new InvestmentForm2(customer1, c);
                frm2.Show();
            }
            if(comboBox1.Text == "OmniAccounts") 
            {
             
                OmniForm3 frm3 = new OmniForm3(customer1,a);
                frm3.Show();
                
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void PopulateComboBox()
        {
            foreach (BankAccounts b in customer1.GetSetAccountType)
            {
               
                comboBox1.Items.Add(b.GetType().Name);
            }
        }
    }
}
