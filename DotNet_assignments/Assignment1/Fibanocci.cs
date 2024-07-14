using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Fibanocci
    {
        static void Main()
        {
            int fib = 40;
            int a = 0;
            int b =1;
            int c;
            for (int i = 2; i < fib; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b; 
                b = c;
            }

        }
    }
}
