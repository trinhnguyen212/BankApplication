using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Customer
    {
        static int nextCustomerID = 1;
        private int customerID;
        private string name;
        private string email;
       // private string phoneNumber;
        private bool isstaff;
        List<BankAccounts> Lst = new List<BankAccounts>();
        //static variable has just one value for the class
       // static int nextCustomerID = 1;
      //  private int customerID;
      //  private string name;
       // private string email;
      //  private bool isstaff;


        public Customer()
        {
            //default constructor
            //each time a book is created its id is set and the nextbookID for the class is increased
            customerID = nextCustomerID;
            nextCustomerID++;
        }
        public Customer(string newName, string newEmail, bool newIsStaff) : this()
        {
            //constructor with parameters. :this ensures the default constructor is alwatys called first.
            name = newName;
            email = newEmail;
            isstaff = newIsStaff;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //public property Author uses lambda notation
        public string Email { get => email; set => email = value; }

        public int CustomerID
        {//bookID is read only.  It cannot be set to a new value
            get { return customerID; }
        }

        public bool IsStaff
        {   //a restricition on what publication year can be set to (20th Century)
            //beware!
            get { return isstaff; }
            set
            {
                isstaff = value;
            }
        }


        public override string ToString()
        {
            return name;
        }

        public string Info()
        {
            return name + "; " + "\n" + email  + ";" + "\n" + "StaffDiscount Status: " + isstaff;
        }
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

        //public double Discount()
        //{
        //    if (isStaff)
        //    {
        //        return 0.5;
        //    }
        //    else { return 1.0; }
        //}

    }
}

