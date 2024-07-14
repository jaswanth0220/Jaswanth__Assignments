using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Bankbalance
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public char TransactionType;
        public int Amount;
        public int Balance;
        public void Accept(int accountNo, string customerName, string accountType, char transactionType, int amount)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
            AccountType = accountType;
            TransactionType = transactionType;
            Amount = amount;

            if (transactionType == 'w')
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
            }
            else if (transactionType == 'd')
            {
                Balance+= amount;
            }
        }


        public void ShowData()
        {
            Console.WriteLine($"Account No: {AccountNo}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Transaction Type: {TransactionType}");
            Console.WriteLine($"Transaction Amount: {Amount}");
            Console.WriteLine($"Current Balance: {Balance}");
        }


        static void Main()
        {
            Bankbalance b = new Bankbalance();
            b.Accept(101, "Jaswanth", "Savings", 'd', 1000);
            b.ShowData();
        }
    }
   
}
