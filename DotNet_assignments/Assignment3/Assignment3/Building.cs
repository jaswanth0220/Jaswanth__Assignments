using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Building
    {
        public string BuildingType;
        public string Capacity;
        public string Dimension;
        public DateTime DateOfCompletion;

        public Building(string buildingType, string capacity, string dimension, DateTime dateOfCompletion)
        {
            BuildingType = buildingType;
            if (BuildingType == "Flat")
            {
                Capacity= capacity;
            }
            else
            {
                Dimension = dimension;
            }
            DateOfCompletion = dateOfCompletion;
        }
        public void showDetails()
        {
            Console.WriteLine($"BuildingType: {BuildingType}  DateofCompletion:{DateOfCompletion.ToShortDateString()}");
            if (Capacity != null)
            {
                Console.WriteLine($"Capacity: {Capacity}");
            
            }
            else
            {
                Console.WriteLine($"Dimension: { Dimension}");
            }
            
        }


        static void Main()
        {
            Building b = new Building("Flat", "3BHK", "0", new DateTime(2001, 2, 20));
            b.showDetails();
            Building b2 = new Building("Villa", "0", "20*30", new DateTime(2024, 7, 11));
            b2.showDetails();
        }
    }
}
