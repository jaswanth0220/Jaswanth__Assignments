namespace Assignment2
{
    internal class Accounts
    {
        public int Account_no;
        public string Customer_name;
        public string Account_type;
        public char Transaction_type;
        public int amount;
        public int balance;

        public void Accept(int account, string customer, string account_type,
           int total)
        {
            Account_no = account;
            Customer_name = customer;
            Account_type = account_type;
            amount = total;
            Console.WriteLine("Your Account No: {0}, Customer Name: {1}, Account Type: {2}, Amount: {3}", Account_no, Customer_name, Account_type, amount);
        }

        public void Transaction(char trans_type, int total_amount)
        {
            if (trans_type == 'd')
            {
                amount += total_amount;
            }
            else if (trans_type == 'w')
            {
                amount -= total_amount;
            }
            Console.WriteLine("Balance amount is " + amount);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Accounts accounts = new Accounts();
            accounts.Accept(54321, "jaswanth", "Current Account", 3000);
            Console.WriteLine("enter the transaction type and amount");
            char Tell_me_type = char.Parse(Console.ReadLine());
            int Tell_me_amount = int.Parse(Console.ReadLine());
            accounts.Transaction(Tell_me_type, Tell_me_amount);
        }
    }
}