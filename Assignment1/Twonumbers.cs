using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Twonumbers
    {
        static void Main()

        {
            Console.WriteLine("enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1+1; i < num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
