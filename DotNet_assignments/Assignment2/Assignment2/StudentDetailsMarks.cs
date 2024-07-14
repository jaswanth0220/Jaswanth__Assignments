using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    
    internal class StudentDetailsMarks
    {
        public int RollNo;
        public string StudName;
        public int MarksInEng;
        public int MarksInMaths;
        public int MarksInScience;


        public StudentDetailsMarks(int Roll_No, string Stud_name,
            int Eng_marks, int Math_marks,int Science_marks) { 

            RollNo = Roll_No;
            StudName = Stud_name;
            MarksInEng = Eng_marks;
            MarksInMaths = Math_marks;
            MarksInScience = Science_marks;

            Console.WriteLine($"Your roll no is {RollNo} Name is " +
                $"{StudName} Marks in each subject are {MarksInEng} " +
                $"{MarksInScience} {MarksInMaths}");

        }

        public void Calculations()
        {
            int total = MarksInMaths + MarksInEng + MarksInScience;
            double avg = total / 3.0;
            Console.WriteLine("Total marks are" + total + "and the percentage is "+
                avg + "%");
        }

        static void Main()
        {
            StudentDetailsMarks details = new StudentDetailsMarks(2,"jaswanth",90,70,50);
            details.Calculations();
        }
    }
}
