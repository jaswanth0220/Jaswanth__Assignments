using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class AscendingOrder
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            Console.WriteLine("enter 10 numbers");


            for(int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nums.Add(number);
            }
            nums.Sort();
            Console.WriteLine("the sorted List is ");
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
