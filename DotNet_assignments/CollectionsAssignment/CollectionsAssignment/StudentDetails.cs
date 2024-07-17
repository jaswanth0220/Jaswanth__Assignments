using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class StudentDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public override string ToString()
        {
            return $"student id:{Id} Name:{Name} Branch:{Branch}";
        }



        static void Main()
        {
            StudentDetails studentDetails = new StudentDetails();

            studentDetails.Id = 18734;
            studentDetails.Name = "jaswanth";
            studentDetails.Branch = "Ece";

            List<StudentDetails> studentDetailsList = new List<StudentDetails>();

            studentDetailsList.Add(new StudentDetails { Id=3498,Name="anirudh",Branch="ece"});
        }

    }
}
