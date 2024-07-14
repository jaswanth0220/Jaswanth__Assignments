using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class NewStudentMarks
    {
        public int roll_no;
        public string name;
        public int standard;
        public int SEM;
        public string Branch;
        public int[] marks;

        public NewStudentMarks(int roll_no, string name, int standard, int SEM, string Branch)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.standard = standard;
            this.SEM = SEM;
            this.Branch = Branch;
            this.marks = new int[5];
        }

        public void EnterMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int sum = 0;
            bool failed = false;

            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    failed = true;
                }
                sum += mark;
            }

            double average = sum / (double)marks.Length;

            if (failed)
            {
                Console.WriteLine("Result: Failed (one or more subjects have marks less than 35)");
            }
            else if (average < 50)
            {
                Console.WriteLine("Result: Failed (average marks less than 50)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }

            Console.WriteLine($"Average Marks: {average:F2}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Roll No: {roll_no}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {standard}");
            Console.WriteLine($"Semester: {SEM}");
            Console.WriteLine($"Branch: {Branch}");
        }

        static void Main()
        {
            NewStudentMarks students = new NewStudentMarks(21, "jaswanth", 10, 3, "ECE");
            students.DisplayDetails();
            students.EnterMarks();
            students.DisplayResult();

        }
    }
}
