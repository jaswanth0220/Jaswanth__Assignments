using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAssignment
{
    internal class Cubes
    {
        static void Main()
        {
            var numbers = new int[] { 2,5,97,4,34,322,35 };
            var cubes = numbers.Where(n => n > 100 && n < 1000).Select(n => n * n * n);

        }
    }
}
