using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Text.RegularExpressions;
namespace CustomerManager
{
    [Serializable]

    public abstract class BankAccounts
    {
        /// <summary>
        /// The BankAccounts class Contains methods & properties for performing basic transaction functions
        /// </summary>
        
        static int nextaccountNumber = 1;
        private int accountNumber;
        private double balance;

        public BankAccounts()
        {
            //default constructor
            //each time an account is created its id is set and the nextaccountNumber for the class is increased
            accountNumber = nextaccountNumber;
            nextaccountNumber++;
        }

        public int accountID
        {
            get { return accountNumber; }
            //   set { accountNumber = value; }
        }
       
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public  void Deposit(double amount)
        {    
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be negative.");
            }
            balance += amount;
        }

        public virtual void  Withdraw(double amount)
        {
            if (amount < 0)
            {
               throw new FailedWithdrawalExcception("** Amount < 0 **");
            }

            if (amount > balance)
            {
                throw new FailedWithdrawalExcception("** Not enough Fund **");
            }
            balance -= amount;
        }

        //  public abstract void Transfer(Customer customer, BankAccounts toAccount, double amount);
        //  {
        
        // }
        public virtual void Transfer(Customer customer, BankAccounts toAccount, double amount)
        {
            double x = amount + customer.Transferfee;
            if (x < 0)
            {
                throw new FailedTransferExcception("Transfered Amount should be > 0");
            }

            if (x > Balance)
            {
                throw new FailedTransferExcception("** Not enough Balance to transfer **");
            }

            if (accountID == toAccount.accountID)
            {
                throw new FailedTransferExcception("** The account Id is invalid **");
            }

            //  int y = 0;
            Balance -= x;
            toAccount.Deposit(amount);
        }
        public virtual string Info()
        {
            return accountID.ToString() + $"  ***Balance: {Balance}";
        }
    }
}
