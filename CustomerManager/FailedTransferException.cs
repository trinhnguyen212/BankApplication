using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    public class FailedTransferExcception : Exception
    {
        // <summary>
        /// This is the exception class for Failed Transfer.
        /// </summary>
        public decimal Deficit
        {
            get;
            set;
        }
        public string FailedMessageTransfer
        {
            get;
            set;
        }
        //public FailedTransferExcception(string message) : base(message)
        //{
        //}
        public FailedTransferExcception(string message)
        {
         //   Deficit = deficit;
            FailedMessageTransfer = message;  
        }
        
    }
}
