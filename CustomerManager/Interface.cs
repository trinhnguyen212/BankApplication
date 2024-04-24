using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
   // [Serializable]
    public interface IObserver
    {
        /// <summary>
        /// This is the interface "IObserver" for Observer pattern.
        /// </summary>
        void Update(BankAccounts p);
  
    }

    public interface ISubject
    {
        /// <summary>
        /// This is the interface "ISubject" for Observer pattern.
        /// </summary>
        void AttachObserver(IObserver obs);
        void NotifyObservers(BankAccounts p);
    }
}
