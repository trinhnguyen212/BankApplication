using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace CustomerManager
{
    [Serializable]

    public class InvestmentAccounts : BankAccounts
    {
        /// <summary>
        /// This is the InvestmentAccount Class inherited from BankAccount class
        /// </summary>

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
                throw new InvestmentAccountException("< 0 . \n **The Withdrawal must be > 0**", ((decimal)amount));
            }

            if (amount > Balance)
            {
                failedTransFee = failedFee;
              
                throw new InvestmentAccountException($"> Balance = {Balance} . \n **Not Enough Balance**", ((decimal)amount));
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
                if (customer.IsStaff == Customer.StaffStatus.Staff)
                {

                    return failedTransFee * 0.5;
                }
                else return failedTransFee;
            }
            else return 0;
        }

        public override string Info()
        {
            return $"Investment Account ID: {base.Info()}";

        }


    }
}
