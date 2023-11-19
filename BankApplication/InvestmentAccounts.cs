using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class InvestmentAccounts : BankAccounts
    {
        private decimal interestRate;
        private double failedFee;

        public double failedTransFee
        {
            get;
            set;
        }
        public decimal interestRated
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public InvestmentAccounts(decimal newinterestRate, double newfailedFee, double newbalance):base()
        {

            this.interestRated = newinterestRate;
            this.failedFee= newfailedFee;
            this.Balance = newbalance;
        }

        public override void Withdraw(double amount)
        {
            if (amount < 0)
            {
                

                throw new ArgumentException("Amount cannot be negative.");
            }

            if (amount > Balance)
            {
                failedTransFee = failedFee;
              
                throw new ArgumentException($"Insufficient balance. Withdrawal Attempt {amount}$ > Balance : {Balance}$");
            }

            Balance -= amount;
            

        }
        public double Caculatedinterest
        {
            get;
            set;
        }

        public double CaCulatedInterest()
        {
                Caculatedinterest = Balance * Convert.ToDouble(interestRated);
                return Caculatedinterest;
            
        }

        public void ApplyInterest()
        {
            if (Caculatedinterest == 0)
            {
                throw new ArgumentException("No interest to Add, please Caculate Interest");
            }
            else
            {
                Balance += Caculatedinterest;
            }
        }
        public double CaculateTransFee(Customer customer)
        {
            if (failedTransFee != 0)
            {
                if (customer.IsStaff)
                {

                    return failedTransFee * 0.5;
                }
                else return failedTransFee;
            }
            else return 0;
        }


    }
}
