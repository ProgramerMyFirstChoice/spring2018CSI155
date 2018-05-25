using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationException
{


    public class NegativeBalanceException : Exception
    {
        private static string msg = "Bank balance is negative. ";
        public NegativeBalanceException() : base(msg)
        {

        }
    }

    public class BankAccount
    {
        private int accountNumber;
        private double balance;

        public int AccountNumber { get; set; }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    NegativeBalanceException nbe = new NegativeBalanceException();
                    throw nbe;
                }

                balance = value;
            }
        }
    }

    public class Program
    {
        
        public static void Main(string[] args)
        {

            BankAccount p1 = new BankAccount();
            try
            {
                p1.AccountNumber = 1234;
                p1.Balance = -1000;
            }
            catch (NegativeBalanceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }

            Console.ReadLine();
        }
    }
}
