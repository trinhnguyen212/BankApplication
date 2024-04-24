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
    public partial class EverydayForm1 : Form
    {
        /// <summary>
        /// This is the form for EveryDay Account
        /// </summary>

        EverydayAccount everydayAccount;
        Customer customer;
       CustomersController _controller;

        public EverydayForm1(Customer customer, EverydayAccount everydayAccount)
        {
            InitializeComponent();
            this.everydayAccount = everydayAccount;
            this.customer = customer;   
        }
        public void SetController(CustomersController controller)
        {
            _controller = controller;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
          //  _controller.reload();   

            this.Close();
           // _controller.WriteBinaryData();
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
            //catch (FormatException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
              catch (EverydayAccountException error)
            {

                MessageBox.Show(error.Message);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
          
            txtWithdrawAmount.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                double Amount = double.Parse(txtTransferAmount.Text);
                //  BankAccounts b=customer.GetCheckAccountNumbers(everydayAccount.accountID, int.Parse(txtTransferAccount.Text));
                customer.GetCheckAccountNumbers(int.Parse(txtTransferAccount.Text));
             //   BankAccounts toAccount;
                foreach (BankAccounts bankAccount in customer.GetSetAccountType)
                {
                  //  customer.GetCheckAccountNumbers(bankAccount);
                    if (bankAccount.accountID == int.Parse(txtTransferAccount.Text))
                        { 
                     
                      // toAccount = bankAccount;
                        everydayAccount.Transfer(customer, bankAccount, Amount);
                        listBox1.Items.Add($"Transfer: {Amount}");
                        listBox1.Items.Add($"No FEE for Transfer Transaction");
                        listBox1.Items.Add($"Current Balance: {everydayAccount.Balance}");

                    }

                }
                


            }
          
            //catch (FormatException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            catch (FailedTransferExcception error)
            {

                MessageBox.Show(error.FailedMessageTransfer);
            }
            txtTransferAmount.Clear();
            txtTransferAccount.Clear();
            //catch (Exception error)
            //{

            //    MessageBox.Show(error.Message);
            //}

            //txtTransferAmount.Clear();
            //txtTransferAccount.Clear(); 
        }
    }
}
