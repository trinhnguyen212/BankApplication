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
     
      Customer customer1 = new Customer();
        public BankForm(Customer customer)
        {
            
            InitializeComponent();
            List<BankAccounts> List = new List<BankAccounts>();
            OmniAccounts a = new OmniAccounts(0.05m, 100, 20, 100);
            List.Add(a);
            EverydayAccount b = new EverydayAccount(140000);
            List.Add(b);
            InvestmentAccounts c = new InvestmentAccounts(0.03m, 20, 5000);
            List.Add(c);
         
            this.customer1 = customer;
            this.customer1.GetSetAccountType = List;
           
            foreach (BankAccounts d in customer1.GetSetAccountType)
            {
                comboBox1.Items.Add(d.GetType().Name);
            }

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
        EverydayForm1 form1;
        OmniForm3 form3;
        InvestmentForm2 form2;
        private void btnApply_Click(object sender, EventArgs e)
        {
            InitializeForm(customer1.GetSetAccountType);
            if (comboBox1.Text == "EverydayAccount")
            {
              form1.Show();
            }
            if (comboBox1.Text == "InvestmentAccounts")
            {
                form2.Show();
            }
            if (comboBox1.Text == "OmniAccounts")
            {
                form3.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InitializeForm(List<BankAccounts> list)
        {
            foreach (BankAccounts b in list)
            {
                if (b.GetType() == typeof(EverydayAccount))
                {
                    form1 = new EverydayForm1(customer1, b as EverydayAccount);
                }
                if (b.GetType() == typeof(InvestmentAccounts))
                {
                    form2 = new InvestmentForm2(customer1, b as InvestmentAccounts);
                }
                if (b.GetType() == typeof(OmniAccounts))
                {
                    form3 = new OmniForm3(customer1, b as OmniAccounts);
                }

            }

        }
    }
}
