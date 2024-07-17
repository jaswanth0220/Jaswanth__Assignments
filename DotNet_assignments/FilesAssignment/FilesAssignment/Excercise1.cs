using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata;
namespace FilesAssignment
{

    internal class Excercise1
    {
        static void Main()
        {
            Console.WriteLine("Hey!, Enter the numbers of names you want to enter");
            int NumOfNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumOfNames; i++)
            {
                string name = Console.ReadLine();
                File.AppendAllText(@"C:\\Users\\ADMIN\\Favorites\\names.txt", Environment.NewLine + name);
            }
        }
    }
}
