using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class EmployeeDetails
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> employees = new SortedDictionary<int, string>();

      
            employees.Add(102, "Aadarsh");
            employees.Add(101, "Jaswanth");
            employees.Add(104, "siddu");
            employees.Add(103, "varun");

            
            Console.WriteLine("Employee List:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee Code: {employee.Key}, Employee Name: {employee.Value}");
            }
        }
    }
}
