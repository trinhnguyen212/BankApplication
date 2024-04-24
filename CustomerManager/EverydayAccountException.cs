using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    public class EverydayAccountException : FailedWithdrawalExcception
    {
        /// <summary>
        /// This is the exception class for EverydayAccount.
        /// </summary>
        public EverydayAccountException(string message): base(message)
        {
        }
        public EverydayAccountException(string message, decimal deficit) : base(message,deficit)
        {
           Deficit = deficit;
           FailedMessage = message;
        }
        public override string Message =>
            $"Everyday Account Failed Withdrawal Exception:\n Withdrawal Amount = {Deficit:C} {FailedMessage}";
    }
}
