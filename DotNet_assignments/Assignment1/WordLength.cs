using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class WordLength
    {
        static void Main()
        {
            Console.WriteLine("enter a word to find the length");
            string word = Console.ReadLine();
            Console.WriteLine(word.Length+" is the length of the word");
        }
    }
}
