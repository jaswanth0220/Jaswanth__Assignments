using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class SameOrNot
    {
        static void Main()
        {
            Console.WriteLine("enter a two words to find whether they are same or not");
            string word = Console.ReadLine();
            string word2 = Console.ReadLine();
            if (word == word2)
            {
                Console.WriteLine("Two words are the same");
            }
            else
            {
                Console.WriteLine("they are differnet");
            }
        }
    }
}
