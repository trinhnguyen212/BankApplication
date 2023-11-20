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
    public partial class EverydayForm1 : Form
    {
       EverydayAccount everydayAccount;
         public EverydayForm1(Customer customer, EverydayAccount everydayAccount)
        {
            InitializeComponent();
            this.everydayAccount = everydayAccount;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Current Balance: {everydayAccount.Balance}");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                double Amount = double.Parse(txtAmount.Text);
            
                everydayAccount.Deposit(Amount);
                txtAmount.Clear();
                listBox1.Items.Add($"Deposit: {Amount}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
            txtAmount.Clear();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double Amount = double.Parse(txtWithdrawAmount.Text);
                everydayAccount.Withdraw(Amount);
                listBox1.Items.Add($"Withdraw: {Amount}");
                txtWithdrawAmount.Clear();           
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
            txtWithdrawAmount.Clear();
        }

       
    }
}
