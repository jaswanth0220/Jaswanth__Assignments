using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Factorial
    {
        static void Main()
        {
            Console.WriteLine("enter the number you want to find the factorial for?");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
