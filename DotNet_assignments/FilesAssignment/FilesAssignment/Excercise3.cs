using System;
using System.IO;

namespace FilesAssignment
{
    internal class Excercise3
    {
        public void MessageHandler(string message)
        {
            string content = message;
            Console.WriteLine(content);
            File.AppendAllText(@"C:\Users\ADMIN\Favorites\error.txt",
                Environment.NewLine + content);
        }

        public void TakeDetails()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a file path to read:");
                string filePath = Console.ReadLine();

                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File content:");
                Console.WriteLine(fileContent);
            }
            catch (FormatException ex)
            {
                MessageHandler("FormatException: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageHandler("FileNotFoundException: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageHandler("Exception: " + ex.Message);
            }
        }

        static void Main()
        {
            Excercise3 excercise3 = new Excercise3();
            excercise3.TakeDetails();
        }
    }
}
