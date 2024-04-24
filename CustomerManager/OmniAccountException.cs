using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    public class OmniAccountException : FailedWithdrawalExcception
    {
        /// <summary>
        /// This is the exception class for OmniAccount.
        /// </summary>
        public OmniAccountException(string message): base(message) { }
        public OmniAccountException(string message, decimal deficit) : base(message, deficit)
        {
            Deficit = deficit;
            FailedMessage = message;
        }
        public override string Message =>
            $"Omni Account Failed Withdrawal Exception:\n Withdrawal Amount = {Deficit:C} {FailedMessage}";

    }
}

