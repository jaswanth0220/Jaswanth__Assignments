using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class SumOfCubes
    {
        static void Main()
        {
            Console.WriteLine("Enter the number you for sum of cubes");
            int a = int.Parse(Console.ReadLine());
            int sum=0;
            for(int i = 0; i <= a; i++)
            {
                sum += i*i*i;
            }
            Console.WriteLine(sum);
        }
    }
}
