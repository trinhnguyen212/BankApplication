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
    public partial class OmniForm3 : Form
    {
        OmniAccounts omniAccounts;
        Customer customer;
        public OmniForm3(Customer customer, OmniAccounts omniAccounts)
        {
            InitializeComponent();
            this.omniAccounts = omniAccounts;
            this.customer = customer;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                double Amount = double.Parse(txtAmount.Text);
                omniAccounts.Deposit(Amount);
                listBox1.Items.Add($"Deposit: {Amount}");
                txtAmount.Clear();
              
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
                double Amount = double.Parse(txtWithdrawOmni.Text);
                omniAccounts.Withdraw(Amount);
                listBox1.Items.Add($"Withdraw: {Amount}");
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
            txtWithdrawOmni.Clear();
            double x = omniAccounts.CaculateTransFee(customer);
            if (x != 0)
            {
                listBox1.Items.Add($"Failed transaction fee: {x}");
                listBox1.Items.Add($"Update balance: {omniAccounts.Balance} - {x} = {omniAccounts.Balance -= x}");
                omniAccounts.failedTransFee = 0;
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Current Balance: {omniAccounts.Balance}");
        }

        private void btnCaculateInterest_Click(object sender, EventArgs e)
        {
            try
            {
               double  x = omniAccounts.Interest();
                listBox1.Items.Add($"Caculated Interest: {x}");
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
        }

        private void btnApplyInterest_Click(object sender, EventArgs e)
        {
            try
            {
                omniAccounts.ApplyInterest();
                listBox1.Items.Add($"Added Interest Balance: {omniAccounts.Balance}");
                omniAccounts.Caculatedinterest = 0;
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
        }

        private void btnCheckOverDraft_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"OverDraft Limit: {omniAccounts.overDraftLimit}");
        }
    }
}
