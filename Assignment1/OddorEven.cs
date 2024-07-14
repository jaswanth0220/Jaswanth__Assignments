using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class OddorEven
    {
        static void Main()
        {
            Console.WriteLine("enter a Total numbers");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine($"Total even numbers are {evenCount} and total odd numbers are{oddCount}");
        }
    }
}