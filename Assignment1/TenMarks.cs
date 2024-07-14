using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TenMarks
    {
        static void Main()
        {
            Console.WriteLine("enter the 10 subjects marks");
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The average of all is "+ (sum / 10));
            int highest = arr[0];
            int lowest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < lowest)
                {
                    lowest = arr[i];
                }

                if (arr[i] > highest)
                {
                    highest = arr[i];
                }
            }
            Console.WriteLine("The highest number is " + highest);
            Console.WriteLine("The lowest number is " + lowest);
            Array.Sort(arr);
            Console.WriteLine("Showing Ascending order");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(arr);
            Console.WriteLine("Showing Descending order");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}
