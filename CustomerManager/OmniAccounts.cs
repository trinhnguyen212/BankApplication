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

    public class OmniAccounts : BankAccounts
    {
        /// <summary>
        /// This is the OmniAccount Class inherited from BankAccount class
        /// </summary>

        private decimal interestRate;
        private double failedFee;
        private double overDraft;
        public double failedTransFee
        {
            get;
            set;
        }
        public double overDraftLimit
        {
            get { return overDraft; }
            set { overDraft = value; }
        }
        public decimal interestRated
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public OmniAccounts(decimal newinterestRate, double newoverDraft, double newfailedFee, double newbalance) :base()
        {
            this.interestRated = newinterestRate;
            this.overDraftLimit = newoverDraft;
            this.failedFee = newfailedFee;
            this.Balance = newbalance;
        }
        public override void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new OmniAccountException("< 0 . \n **The Withdrawal must be > 0**", ((decimal)amount));
            }

            if (amount > Balance + overDraftLimit)
            {
                failedTransFee = failedFee;
                throw new OmniAccountException($"> Balance({Balance:C} ) + OverdraftLimit( {overDraftLimit:C} ) = {Balance + overDraftLimit} . \n **Not Enough Balance + OverDraft**", ((decimal)amount))
                {
                    
                };
            }
            Balance -= amount;
        }
        public double Caculatedinterest
        {
            get;
            set;
        }


        public double Interest()
        {
            if (Balance < 1000)
            {
                throw new ArgumentException("Your fund not >1000$");
            }
            else
            {
               return CaCulatedInterest();
            }
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
                return failedTransFee;
            }
            else return 0;
        }

        public override string Info()
        {
            return $"Omni Account ID: {base.Info()}";

        }

       // public do

       
    }
}
