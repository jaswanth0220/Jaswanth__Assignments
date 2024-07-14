using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Largestofthree
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers");
            int[] arr = new int[3];
           
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > largest)
                {
                    largest = arr[i];
                }

            }
            Console.WriteLine(largest+" is the largest number of all");
        }

    }
}
