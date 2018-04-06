using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Containment_Example_1
{
    public partial class Form1 : Form
    {
       
        //create a list of customers
        List<Customer> customerList = new List<Customer>();
        //instantiate Validator
        Validator val = new Validator();
        //instantiate Customer
        Customer c = new Customer();
        //instantiate Account
        Account a = new Account();
        public Form1()
        {
            InitializeComponent();
            //load with premade Customerlist
            // PreLoadsCustomerList();
        }
       
        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            if (val.IsPresent(txtAccountNum))
            {
                if (val.IsDecimal(txtBalance))
                {
                    if (val.IsInt32(txtAccountNum))
                    {
                        a.Balance = int.Parse(txtBalance.Text);
                        string acctype = txtAccountType.Text;
                        acctype.ToLower();
                        if (acctype == "checking" || acctype == "savings" || acctype == "cd")
                        {
                            a.Type = (AccountType)Enum.Parse(typeof(AccountType), txtAccountType.Text);
                            //
                        }
                    }
                        

                    

                }
            }
        }
        private void BtnDisplay(object sender, EventArgs e)
        {
            ClearTextboxes();
            PreLoadsCustomerList();
        }
        private void BtnCloseAccount(object sender, EventArgs e)
        {
           
        }

        //define a method that takes a customer id and
        //return the customer object or null if not found
        //private Customer GetCustomerByID(int id)
        //{
        //    return id;
        //}
        //method to display customers
        public void DisplayCustomers()
        {


        }
        //define a method that preloads the customerList with
        //few customers
        private void PreLoadsCustomerList()
        {
            Customer customer1 = new Customer("Andy", "Adams", 1234);
            //add few accounts to this customer
            Account a1 = new Account(1230, 3300, AccountType.checking,
                                       new DateTime(2017, 2, 12));
            Account a2 = new Account(1434, 9900, AccountType.checking,
                                       new DateTime(2015, 9, 1));
            //add this account to the customer
            customer1.Add(a1);
            customer1.Add(a2);
            customerList.Add(customer1);
            richTextBox1.Clear();
          
            //----------------------------------------------------------
            Customer customer2 = new Customer("Beth", "Bartos", 1235);
            //add few accounts to this customer
            a1 = new Account(1554, 1299, AccountType.savings,
                                       new DateTime(2016, 1, 31));
            a2 = new Account(1466, 3389, AccountType.checking,
                                       new DateTime(2014, 12, 1));
            //add this account to the customer
            customer2.Add(a1);
            customer2.Add(a2);
            customerList.Add(customer2);
            
            //----------------------------------------------------------
            Customer customer3 = new Customer("Chelsea", "Caday", 1236);
            //add few accounts to this customer
            a1 = new Account(2554, 2998, AccountType.savings,
                                       new DateTime(2011, 7, 7));
            a2 = new Account(2466, 3399, AccountType.checking,
                                       new DateTime(2015, 6, 8));
            //add this account to the customer
            customer3.Add(a1);
            customer3.Add(a2);
            customerList.Add(customer3);
            
            //----------------------------------------------------------
            Customer customer4 = new Customer("Gary", "Jordan", 1237);
            //add few accounts to this customer
            a1 = new Account(3554, 1298, AccountType.savings,
                                       new DateTime(2015, 9, 6));
            a2 = new Account(3466, 3899, AccountType.checking,
                                       new DateTime(2015, 4, 2));
            //add this account to the customer
            customer4.Add(a1);
            customer4.Add(a2);
            customerList.Add(customer4);
            PreloadToRichbox();
        }

        private void PreloadToRichbox()
        {
            foreach (Customer cust in customerList)
            {
                richTextBox1.AppendText(cust.FirstName + "  " + cust.LastName + "   " + cust.ID + "  " + "\n\n");
                foreach (Account acct in cust.Accounts)
                {
                    richTextBox1.AppendText(acct.AccountNumber.ToString() + "  "
                        + acct.Balance.ToString() + acct.Type + "  "
                        + acct.DateCreated.ToShortDateString() + "\n");

                    richTextBox1.AppendText("\n\n");
                }
            }
        }

        public void ClearTextboxes()
        {
            txtAccountNum.Clear();
            txtAccountNumber2.Clear();
            txtAccountType.Clear();
            txtBalance.Clear();
            txtCustID.Clear();
            txtCustID2.Clear();
        }

    }
}
                    

 


///Create new project: 
///Add class: Vehicle (_make, _model, _year, _price, _vin)
///declare the make of the vehicle an enum 
///with at least 5 auto makers for example (Ford, Chevy, Dodge, Mercedes, Toyota)
///Add constructor and get properties
///Method: UpdatePrice(decimal newPrice)
///
///Add a class: Person (_firstname, _lastname, List<Vehicle> vehicleList)
///Add constructor, get properties
///Method: Add(Vehicle v)
///Method: Remove(string vin) (remove by vin number)
///
///Add a Validation class for user input
///
///in Form1: create a list of people
///preload the list with at least 7 people to each add
///at least 2 vehicles
///
///provide gui to display all the people and their vehicles
///provide gui to add a vehicle to a person
///provide gui to update the price of a vehicle of a person
///provide gui to remove (sell) a car of a person
