using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class BankForm1 : Form
    {
        //a list to maintain objects of the book class
        private List<Customer> AllCustomers = new List<Customer>();
        public BankForm1()
        {
            InitializeComponent();
            //read in some book data
            ReadCustomerFile();
            DisplayCustomers();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }


        private void Play()
        {
            if (lblInfo.Text != string.Empty)
            {
                Customer customer = (Customer)lstBooks.SelectedItem;
                //customer.GetSetAccountType = List;
                //try out bits of your own code here.
                BankForm bankfrm1 = new BankForm(customer);
                bankfrm1.Show();
            }
            else
            {
                MessageBox.Show("please choose customer!");
            }


           
        }

        public void DisplayCustomers()
        {
            //make sure listbox is empty
            lstBooks.Items.Clear();
            //Add the book titles to the listBox
            foreach (Customer b in AllCustomers)
            {
                lstBooks.Items.Add(b);
            }
            //Select the first item
          //  lstBooks.SelectedIndex = 0;
        }

        //private void btnGetInfo_Click(object sender, EventArgs e)
        //{
        //    Customer customer = (Customer)lstBooks.SelectedItem;
        //    lblInfo.Text = customer.Info();

        //}

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
            lblInfo.Text = "";
        }



        private void ReadCustomerFile()
        {
            //read data from a file into Book objects
            Customer customer;
            string[] strArray;

            //open file
            var myfile = new StreamReader("../../customer.txt");

            while (!myfile.EndOfStream)
            {
                //read line and split into substrings
                strArray = myfile.ReadLine().Split(',');
                //call book constructor using info from line of file
                customer = new Customer(strArray[0], strArray[1], Convert.ToBoolean(strArray[2]));
                //add object to List
                AllCustomers.Add(customer);
            }
            myfile.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)lstBooks.SelectedItem;
            lblInfo.Text = customer.Info();
        }
    }
}
