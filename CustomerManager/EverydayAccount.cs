using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace CustomerManager
{
    [Serializable]

    public class EverydayAccount : BankAccounts
    {
        /// <summary>
        /// This is the EverydayAccount Class inherited from BankAccount class
        /// </summary>
        public EverydayAccount(double balance): base()
        {
            this.Balance = balance;
        }
        public override void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new EverydayAccountException("< 0 . \n **The Withdrawal must be > 0**", ((decimal)amount));
            }

            if (amount > Balance)
            {
                decimal x = ((decimal)(Balance - amount));
                throw new EverydayAccountException($"> Balance = {Balance} . \n **Not Enough Balance**",((decimal)amount));
            }
            Balance -= amount;
        }
        public override void Transfer(Customer customer, BankAccounts toAccount, double amount)
          {
            if (amount < 0)
            {
                throw new FailedTransferExcception("Transfered Amount should be > 0");
            }

            if (amount > Balance)
            {
                throw new FailedTransferExcception("** Not enough Balance to transfer **");
            }

            if (accountID == toAccount.accountID)
            {
                throw new FailedTransferExcception("** The account Id is invalid **");
            }

            //  int y = 0;
            Balance -= amount;
            toAccount.Deposit(amount);
        }
        public override string Info()
        {
            return $"Everyday Account ID: {base.Info()}";
        }
    }
}
