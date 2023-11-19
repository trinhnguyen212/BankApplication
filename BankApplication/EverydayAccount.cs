using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class EverydayAccount : BankAccounts
    {
        public EverydayAccount(double blance): base()
        {
            this.Balance = blance;
        }
    }
}
