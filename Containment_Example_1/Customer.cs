using System;
using System.Collections.Generic;
using System.Linq;

namespace Containment_Example_1
{
    public class Customer
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        private List<Account> accountList; //containment by composition
        //copy the list of accounts to an array of accounts
        public Account[] Accounts { get{ Account[] accounts = accountList.ToArray(); return accounts;} }

        //constructor
        public Customer(string firstname, string lastname, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            accountList = new List<Account>();
        }
        public Customer() { }
        public void Add(Account account)
        {
            //you may do any checking to make sure that the 
            //account has all the valid data...
            if(account != null && !String.IsNullOrEmpty(FirstName) && !String.IsNullOrEmpty(LastName))
            {
                //adds the account to the accountList
                accountList.Add(account);
            }          
        }
        public decimal Close(int accountNumber)
        {
            //code to add call the GeAccount to get the Account object
            Account account = GetAccount(accountNumber);
            //make sure that it is not null
            if (account != null)
            {
                //remove it from the accountList
                accountList.Remove(account);
                return account.Balance;
            }
            return 0;               
        }
        //helper method
        private Account GetAccount(int accountNumber)
        {
            //search thru the accountList and return the 
            //Account object with the given accountNumber
            //or null if not found
            foreach(Account account in accountList)
            {
                if (account.AccountNumber == accountNumber)
                    return account;
            }
            return null;
        }
    }
}
