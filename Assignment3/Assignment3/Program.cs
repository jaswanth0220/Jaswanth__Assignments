namespace Assignment3
{
    internal class Program
    {
        public string FirstName;
        public string  LastName;
        public string EmailAddress;
        public DateTime DateOfBirth;

        public Program(string firstName, string lastName, string emailAddress,DateTime dateOfBirth) 
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            DateOfBirth = dateOfBirth;
        }
        public Program(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }
        public Program(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public void DisplayDetials()
        {
            Console.WriteLine($"Firstname {FirstName} Lastname {LastName} Email: {EmailAddress} DOB: {DateOfBirth.ToShortDateString()} ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program("Jaswanth","ch","chjaswanth321@gmail.com",new DateTime(2001,2,20));
            p.DisplayDetials();
        }
    }
}
