using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CustomerManager
{
  
    public partial class CustomersView : Form
    {
        CustomersController _controller;
   
         List<Customer> customers = new List<Customer>();


        /// <summary>
        /// This is a View class part of the Model View Controller (MVC) pattern
        /// </summary>
        public CustomersView()
        {
            InitializeComponent();
          //  _controller = controller;
      
        }


        #region Events raised  back to controller

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            this._controller.AddNewCustomer();
           
            //this._controller.clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            this._controller.RemoveCustomer();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
         
                this._controller.Save();
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._controller.Update();

        }

        #endregion

        #region ICatalogView implementation

        public void SetController(CustomersController controller)
        {
            _controller = controller;
        //    this._controller.ReadBinaryData();
            //  _controller.ReadBinaryData();

        }
        //public void WriteBinaryData()
        //{
        //    //create a formatting object
        //    IFormatter formatter = new BinaryFormatter();

        //    //Create a new IO stream to write to the file Objects.bin
        //    Stream stream = new FileStream("objects.bin", FileMode.Create,
        //    FileAccess.Write, FileShare.None);

        //    //use the formatter to serialize the collection and send it to the filestream
        //    formatter.Serialize(stream, _controller._customers);
        //    //foreach(Customer customer in _customers)
        //    //{
        //    //    formatter.Serialize(stream, customer.GetSetAccountType);

        //    //}
        //    stream.Close();

        //}
        public void ReadBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            _controller._customers = (List<Customer>)formatter.Deserialize(stream);
            //foreach (Customer customer in _customers)
            //{
            //    customer.GetSetAccountType = (List<BankAccounts>)formatter.Deserialize(stream);


            //}
            stream.Close();
        }

        public void ClearGrid()
        {
            // Define columns in grid
            this.grdCustomers.Columns.Clear();

            this.grdCustomers.Columns.Add("Id",          50,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("First Name",  150,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("Last Name", 150,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("Nationality",  150,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("Staff Status",         100,   HorizontalAlignment.Left);

            // Add rows to grid
            this.grdCustomers.Items.Clear();
        }
        public void ClearTxt()
        {
            FirstName= string.Empty;
            LastName= string.Empty;
            Nationality= string.Empty;
            ID= string.Empty;
            IsStaff = Customer.StaffStatus.NonStaff;
        }

      

        public void AddCustomerToGrid(Customer usr)
        {
            ListViewItem parent;
            parent = this.grdCustomers.Items.Add(usr.ID);
            parent.SubItems.Add(usr.FirstName);
            parent.SubItems.Add(usr.LastName);
            parent.SubItems.Add(usr.Nationality);
            parent.SubItems.Add(Enum.GetName(typeof(Customer.StaffStatus), usr.IsStaff));
        }

        public void UpdateGridWithChangedCustomer(Customer usr)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdCustomers.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = usr.ID;
                rowToUpdate.SubItems[1].Text = usr.FirstName;
                rowToUpdate.SubItems[2].Text = usr.LastName;
                rowToUpdate.SubItems[3].Text = usr.Nationality;
                rowToUpdate.SubItems[4].Text = Enum.GetName(typeof(Customer.StaffStatus), usr.IsStaff);
            }
        }

        public void RemoveCustomerFromGrid(Customer usr)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.grdCustomers.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.grdCustomers.Items.Remove(rowToRemove);
                this.grdCustomers.Focus();
            }
        }
        public bool CheckTxt()
        {
            if (FirstName!= "" & LastName != "" & Nationality != "" & ID !="" )
            {
                return true;
            }
            else
            {
                MessageBox.Show("!! Input ERROR, please press 'Add New Customer' button!!");
                return false; 
            }
        }
        public string GetIdOfSelectedCustomerInGrid()
        {
            if (this.grdCustomers.SelectedItems.Count > 0)
                return this.grdCustomers.SelectedItems[0].Text;
            else
            {

                return "";
            }

        }

        public void SetSelectedCustomerInGrid(Customer usr)
        {
            foreach (ListViewItem row in this.grdCustomers.Items)
            {
                if (row.Text == usr.ID)
                {
                    row.Selected = true;
                }
            }
        }

        public string FirstName 
        {
            get { return this.txtFirstName.Text; }
            set { this.txtFirstName.Text = value; }
        }

        public string LastName 
        {
            get { return this.txtLastName.Text; }
            set { this.txtLastName.Text = value; }
        }

        public string ID
        {
            get { return this.txtID.Text; }
            set { this.txtID.Text = value; }
        }


        public string Nationality 
        {
            get { return this.txtNationality.Text; }
            set { this.txtNationality.Text = value; }
        }

        public Customer.StaffStatus IsStaff
        {
            get
            {
                if (this.rdNonStaff.Checked)
                    return Customer.StaffStatus.NonStaff;
                else
                    return Customer.StaffStatus.Staff;
            }
            set
            {
                if (value == Customer.StaffStatus.NonStaff)
                    this.rdNonStaff.Checked = true;
                else
                    this.rdStaff.Checked = true;
            }
        }

        public bool CanModifyID
        {
            set { this.txtID.Enabled = value; }
        }

        #endregion

      

        private void grdCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdCustomers.SelectedItems.Count > 0)
                this._controller.SelectedCustomerChanged(this.grdCustomers.SelectedItems[0].Text);
        }

        private void CustomersView_Load(object sender, EventArgs e)
        {

        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
          //  this._controller.CloseBankForm();   
            this._controller.SetSelectedCustomer();
        }

       
        
        
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
            //WriteBinaryData();  
        }
    }
}
