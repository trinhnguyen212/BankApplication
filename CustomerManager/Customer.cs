using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace CustomerManager
{
    [Serializable]

    public class Customer: ISubject
    {
        /// <summary>
        /// This is the Customer Model class part of the Model View Controller (MVC) pattern
        /// </summary>

        public List<BankAccounts> Catalog = new List<BankAccounts>();
        public List<IObserver> MyObservers = new List<IObserver>();
        static double _transferfee = 5;

        public void AddInvestmentAccount()
        {
            BankAccounts p = new InvestmentAccounts(1, 10, 2000);
            Lst.Add(p);
            NotifyObservers(p);
        }
        public void AddEverydayAccount()
        {
            BankAccounts p = new EverydayAccount(1000);

            Lst.Add(p);
            NotifyObservers(p);
        }
        public void AddOmniAccount()
        {
            BankAccounts p = new OmniAccounts(2, 100, 20, 4000);
            Lst.Add(p);
            NotifyObservers(p);
        }

        public void AttachObserver(IObserver obs)
        {
            MyObservers.Add(obs);
        }

        public void NotifyObservers(BankAccounts p)
        {
            foreach (IObserver obs in MyObservers)
            {
                obs.Update(p);
            }
        }
        public void GetCheckAccountNumbers(int toAccount)
        {
            int y = 0;
            foreach (BankAccounts bankAccounts in Lst)
            {
                if (bankAccounts.accountID == toAccount)
                { y = 1; }
            }

            if (y == 0)
            {
                throw new FailedTransferExcception("No account");
            }
        }

        private static int nextID = 1;
        public enum StaffStatus
        {
            Staff = 1,
            NonStaff = 2
        }
        private List<BankAccounts> Lst = new List<BankAccounts>();
        public List<BankAccounts> GetSetAccountType
        {
            get
            {
                return Lst;
            }
            set
            {
                Lst = value;
            }
        }
        private StaffStatus _IsStaff;
        public StaffStatus IsStaff
        {
            get { return _IsStaff; }
            set { _IsStaff = value; }
        }
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! FirstName must be less than 51 characters!");
                else
                    _FirstName = value;
            }
        }
        public double Transferfee
        {
            //get { return _FirstName; }
           get
            {
                if (IsStaff == Customer.StaffStatus.Staff)
                { return _transferfee * 0.5; }
                else
                { return _transferfee; }
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! LastName must be less than 51 characters!");
                else
                    _LastName = value;
            }
        }

        private string _ID;
        public string ID
        {
            get { return _ID; }
            set
            {
                if (value.Length > 9)
                    Console.WriteLine("Error! ID must be less than 10 characters!");
                else
                    _ID = value;
            }
        }

        private string _Nationality;
        public string Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        }

      

        public Customer()
        {
            ID = nextID.ToString();
            nextID++;

        }
        public Customer(string firstname, string lastname, string nationality, StaffStatus isstaff) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            //  ID          = nextID.ToString();
            Nationality = nationality;
            IsStaff = isstaff;
            // nextID++;

        }

        
    }
}
