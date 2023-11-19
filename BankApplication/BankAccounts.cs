using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public abstract class BankAccounts
    {

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
                
                throw new ArgumentException("Amount cannot be negative.");
            }

            if (amount > balance)
            {
              
                throw new ArgumentException("Insufficient balance.");
            }
           
            balance -= amount;
        
    
        }

       
    }
}
