using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class StudentNames
    {
        static void Main()
        {
            List<string> StudentNames = new List<string>();
            Console.WriteLine("Enter the total number of students");
            int total = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student names");
            for (int i = 0; i < total; i++)
            {
                StudentNames.Add(Console.ReadLine());
            }
            //sort in descending
            StudentNames.Sort();
            StudentNames.Reverse();

            Console.WriteLine("Reversed list is ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(StudentNames[i]);
            }
        }
    }
}