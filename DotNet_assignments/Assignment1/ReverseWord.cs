using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ReverseWord
    {
        static void Main()
        {
            Console.WriteLine("enter a word to reverse it");
            string word = Console.ReadLine();
            int length;
            string reverseword = "";
            length = word.Length-1;
            while (length >= 0) {
                reverseword += word[length];
                length--;
            }
            Console.WriteLine(reverseword);
        }
    }
}
