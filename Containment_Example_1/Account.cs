using System;

namespace Containment_Example_1
{
    public enum AccountType {checking, savings, cd}
    public class Account
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public AccountType Type { get; set; }
        public DateTime DateCreated { get; set; }
    
        public Account(int accountNumber, decimal balance, AccountType type, DateTime dateCreated)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Type = type;
            DateCreated = dateCreated;
        }
        public Account() { }
      

        public bool WithDraw(decimal amount)
        {
            //To Do for later: complete code
            if (Balance > amount)
            {
                Balance -= amount;
                return true;
            }
                return false;
        }
        public void Deposit (decimal amount)
        {
            //To Do for later: complete code
            Balance += amount;
        }
    }
}
