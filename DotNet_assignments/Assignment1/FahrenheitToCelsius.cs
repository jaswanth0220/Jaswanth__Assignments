using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FahrenheitToCelsius
    {
        static void Main()
        {
            Console.WriteLine("enter the temperature in fehrenheit");
            double f = double.Parse(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine(c);
        }
    }
}
