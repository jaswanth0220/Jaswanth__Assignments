using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FilesAssignment
{
    class Car
    {
        public string Model;
        public DateTime Year;

        public Car(string model, DateTime year)
        {
            Model = model;
            Year = year;
        }

        public void PushDetails(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                string content = $"The model name is {Model} and year is {Year}";
                sw.WriteLine(content);
            }
        }
        public void GetDetails(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
    internal class Excercise2
    {
        static void Main()
        {
            Car car = new Car("tesla", new DateTime(2022,2, 02));
            car.PushDetails("C:\\Users\\ADMIN\\Favorites\\carDetails.txt");
            car.GetDetails("C:\\Users\\ADMIN\\Favorites\\carDetails.txt");
        }

    }
}
