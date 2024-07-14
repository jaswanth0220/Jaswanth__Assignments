using System;

namespace Assignment2
{
    internal class CreditCardBills
    {
        public float DebtAmount;
        public float MonthlyAmount;
        public float InterestRate = 0.015f;

        public void EnterDetails()
        {
            Console.WriteLine("Enter the debt amount and monthly amount you want to pay:");
            DebtAmount = float.Parse(Console.ReadLine());
            MonthlyAmount = float.Parse(Console.ReadLine());
        }

        public void CalculateBalance()
        {
            float balance = DebtAmount;
            float totalPayments = 0;
            int month = 1;

            while (balance > 0)
            {
                
                float interest = balance * InterestRate;

                
                float actualPayment = (balance + interest) < MonthlyAmount ? (balance + interest) : MonthlyAmount;

                
                balance = balance + interest - actualPayment;

                
                totalPayments += actualPayment;

                
                Console.WriteLine($"Month: {month} Balance: {balance:F2} Total Payments: {totalPayments:F2}");

         
                month++;
            }
        }

        static void Main()
        {
            CreditCardBills c = new CreditCardBills();

            c.EnterDetails();
            c.CalculateBalance();
        }
    }
}
