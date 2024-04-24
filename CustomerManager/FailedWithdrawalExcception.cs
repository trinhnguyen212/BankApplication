using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    public class FailedWithdrawalExcception : Exception
    {
        /// <summary>
        /// This is the exception class for Failed Withdrawl.
        /// </summary>
        public decimal Deficit
        {
            get;
            set;
        }
        public string FailedMessage
        {
            get;
            set;
        }
        public FailedWithdrawalExcception(string message) : base(message)
        {
        }
        public FailedWithdrawalExcception(string message, decimal deficit)
        {
            Deficit = deficit;
            FailedMessage = message;  
        }
        
    }
}
