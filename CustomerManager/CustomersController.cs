using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomerManager
{
    [Serializable]
   
    public class CustomersController
    {
        /// <summary>
        /// This is the Controller class part of the Model View Controller (MVC) pattern
        /// </summary>


        CustomersView _view;
        frmControl _frmControl;
        frmAddAccount _frmAddAccount;
        frmLatestAccount _frmLatestAccount;
        frmCatalog _frmCatalog;
      //  OmniForm3 _omniForm;
        EverydayForm1 _everydayForm;
        //InvestmentForm2 investmentForm;

        public List<Customer> _customers= new List<Customer>();
        public List<BankAccounts> _customersaccount= new List<BankAccounts>();
           
        BankAccounts _selectedBankAccount;


        Customer _selectedCustomer;
        /// <summary>
        /// Initiate a CustomerView view along with a list of customers.
        /// </summary>
        /// <param name="view">A CustomerView view.</param>
        /// <param name="customers">A List of Customer.</param>
        /// <returns>
        /// The instance of the CustomerController class.
        /// </returns>
        public CustomersController(CustomersView view, List<Customer> customers)
        {
          _view = view;
            _customers = customers;
            _view.SetController(this);
        }

        /// <summary>
        /// Initiate a frmAddAccount view along with a list of customers.
        /// </summary>
        /// <param name="frmAddAccount">A frmAddAccount view.</param>
        /// <param name="customer">A List of Customer.</param>
        /// <returns>
        /// The instance of the CustomerController class.
        /// </returns>
        public CustomersController(frmAddAccount frmAddAccount, Customer customer)
        {
            _frmAddAccount = frmAddAccount;
            _selectedCustomer = customer;
            frmAddAccount.SetController(this);
        }

        /// <summary>
        /// Initiate a frmCatalog view along with a list of customers.
        /// </summary>
        /// <param name="frmCatalog">A frmCatalog view.</param>
        /// <param name="customer">A List of Customer.</param>
        /// <returns>
        /// The instance of the CustomerController class.
        /// </returns>
        public CustomersController(frmCatalog frmCatalog, Customer customer)
        {
            _frmCatalog = frmCatalog;
            _selectedCustomer = customer;
            frmCatalog.SetController(this);
        }

        

        /// <summary>
        /// Update View with Customer Detail Value.
        /// </summary>
        /// <param name="csr">A List of Customer.</param>
        private void updateViewDetailValues(Customer csr)
        {
           _view.FirstName   =  csr.FirstName;
           _view.LastName    =  csr.LastName;
           _view.ID          =  csr.ID;
           _view.Nationality  =  csr.Nationality;
           _view.IsStaff = csr.IsStaff;
        }

        /// <summary>
        /// Update Customer with View Value.
        /// </summary>
        /// <param name="csr">A List of Customer.</param>
        private void updateCustomerWithViewValues(Customer csr)
        {
            if (this._view.CheckTxt())
            {
                csr.FirstName = _view.FirstName;
                csr.LastName = _view.LastName;
                csr.ID = _view.ID;
                csr.Nationality = _view.Nationality;
                csr.IsStaff = _view.IsStaff;
            }

        }

        /// <summary>
        /// Load Customer to CustomerView
        /// </summary>
        public void LoadView()
        {
            _view.ClearGrid();
            foreach (Customer csr in _customers)
                _view.AddCustomerToGrid(csr);
   
        }

        /// <summary>
        /// Load a customer's detail to frmAddAccount
        /// </summary>
        public void LoadView1()
        {
            _frmAddAccount.FirstName = _selectedCustomer.FirstName;
            _frmAddAccount.ID = _selectedCustomer.ID;
            _frmAddAccount.IsStaff = _selectedCustomer.IsStaff;
    
        }

        /// <summary>
        /// Update customer's bankaccount list
        /// </summary>
        public void LoadView2()
        {
            _frmCatalog.lstCatalog.Items.Clear();
            foreach (BankAccounts p in _selectedCustomer.GetSetAccountType)
            {
                _frmCatalog.Update(p);
            }
           
        }

        /// <summary>
        /// Change Selected Customer
        /// </summary>
        public void SelectedCustomerChanged(string selectedCustomerId)
        {
            foreach (Customer csr in this._customers)
            {
                if (csr.ID == selectedCustomerId)
                {
                    _selectedCustomer = csr;
                    updateViewDetailValues(csr);
                    _view.SetSelectedCustomerInGrid(csr);
                    this._view.CanModifyID = false;
                    break;
                }
            }
       
        }

        /// <summary>
        /// To Add new customer.
        /// </summary>
        public void AddNewCustomer()
        {
          

            _selectedCustomer = new Customer(""/*firstname*/,
                                     "" /*lastname*/,
                                     //   ""  /*id*/, 
                                     "" /*department*/,
                                     Customer.StaffStatus.Staff /*sex*/);

            this.updateViewDetailValues(_selectedCustomer);
                this._view.CanModifyID = false;
        }

        /// <summary>
        /// To Remove Customer.
        /// </summary>
        public void RemoveCustomer()
        {
           
            if (this._customers.Count >0)
            {
                string id = this._view.GetIdOfSelectedCustomerInGrid();
                Customer customerToRemove = null;

                if (id != "")
                {
                    foreach (Customer csr in this._customers)
                    {
                        if (csr.ID == id)
                        {
                            customerToRemove = csr;
                            break;
                        }                    
                    }
                    if (customerToRemove != null)
                    {
                        int newSelectedIndex = this._customers.IndexOf(customerToRemove);
                        this._customers.Remove(customerToRemove);
                        this._view.RemoveCustomerFromGrid(customerToRemove);

                        if (newSelectedIndex > -1 && newSelectedIndex < _customers.Count)
                        {
                            this._view.SetSelectedCustomerInGrid((Customer)_customers[newSelectedIndex]);
                        }
                        else { this._view.ClearTxt(); }
                    }
                }
            }
        }

        /// <summary>
        /// Save customer
        /// </summary>
        public void Save()
        {
            if (this._view.CheckTxt())
            {
                updateCustomerWithViewValues(_selectedCustomer);
                if (!this._customers.Contains(_selectedCustomer))
                {
                    // Add new customer
                    this._customers.Add(_selectedCustomer);
                    this._view.AddCustomerToGrid(_selectedCustomer);
                }
               
                this._view.CanModifyID = false;
            }
        }

        /// <summary>
        /// Update Customer Detail With View Values.
        /// </summary>
        public void Update()
        {
            updateCustomerWithViewValues(_selectedCustomer);
            if (this._customers.Contains(_selectedCustomer))
            {
           
                this._view.UpdateGridWithChangedCustomer(_selectedCustomer);
            }
    
            this._view.CanModifyID = false;
        }

        /// <summary>
        /// Set Selected Customer To frmControl.
        /// </summary>
        public void SetSelectedCustomer ()
        {
            if (_frmControl != null)
            {
                _frmControl.Close();
            }
            _frmControl = new frmControl(_selectedCustomer);

            _frmControl.Show();
        }

        /// <summary>
        /// To Add EveryDayAccount to Customer' bankaccount list.
        /// </summary>
        public void AddEveryDayAccount ()
        {
            _selectedCustomer.AddEverydayAccount();
        }

        /// <summary>
        /// To Add OmniAccount to Customer' bankaccount list.
        /// </summary>
        public void AddOmniAccount ()
        {
            _selectedCustomer.AddOmniAccount();
        }

        /// <summary>
        /// To Add OmniAccount to Customer' bankaccount list.
        /// </summary>
        public void AddInvestmentAccount ()
        {
            _selectedCustomer.AddInvestmentAccount();
        }

        /// <summary>
        /// To Deserialize Data
        /// </summary>
        public void ReadBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            _customers = (List<Customer>)formatter.Deserialize(stream);
          
            stream.Close();
        }

        /// <summary>
        /// To Serialize Data
        /// </summary>
        public void WriteBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            
            stream.Close();

        }

        /// <summary>
        /// To Manage Selected Account's Transaction.
        /// </summary>
        public void ManageSelectedAccount()
        {
            
            foreach (BankAccounts bankAccount in _selectedCustomer.GetSetAccountType)
            {
                if (bankAccount.Info() == _frmCatalog.lstCatalog.SelectedItem.ToString())
                {
                    _selectedBankAccount = bankAccount;
                    if (_selectedBankAccount.GetType() == typeof(OmniAccounts))
                    {
                        OmniForm3 omni = new OmniForm3(_selectedCustomer, (OmniAccounts)_selectedBankAccount);
                        omni.Show();
                        break;
                    }

                    if (_selectedBankAccount.GetType() == typeof(EverydayAccount))
                    {
                        EverydayForm1 everyday = new EverydayForm1(_selectedCustomer, (EverydayAccount)_selectedBankAccount);

                        everyday.Show();
                        break;
                    }

                    if (_selectedBankAccount.GetType() == typeof(InvestmentAccounts))
                    {
                        InvestmentForm investment = new InvestmentForm(_selectedCustomer, (InvestmentAccounts)_selectedBankAccount);
                        investment.Show();
                        break;                       
                    }                 
                }
            }
        }
    }
}
