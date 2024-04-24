using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CustomerManager
{
    [Serializable]

    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
     
        /// 
        [STAThread]
        static void Main()
        {
       
               CustomersView view = new CustomersView();      
               view.Visible = false;

            //  IList customers = new ArrayList();
             List<Customer> customers= new List<Customer>();
            customers.Add(new Customer("Tracy", "Nguyen", "Vietnamese", Customer.StaffStatus.Staff));
            customers.Add(new Customer("Tim", "Kapoor", "USA", Customer.StaffStatus.Staff));
            customers.Add(new Customer("Steven", "Song", "Canadian", Customer.StaffStatus.NonStaff));

            CustomersController controller = new CustomersController(view,customers);
           //   controller.ReadBinaryData();
                controller.LoadView();
                view.ShowDialog();
        }       
    }
}
