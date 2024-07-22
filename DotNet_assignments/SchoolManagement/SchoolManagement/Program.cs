using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SchoolManagement
{
    class Program
    {
        static List<Staff> staffs = new List<Staff>();
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Staff to the system");
                Console.WriteLine("2. Add Student to the system");
                Console.WriteLine("3. Display all Students as per Staff");
                Console.WriteLine("4. Display all Students as per Class");
                Console.WriteLine("5. Display all Students and write to text file");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStaff();
                        break;
                    case 2:
                        AddStudent();
                        break;
                    case 3:
                        DisplayStudentsByStaff();
                        break;
                    case 4:
                        DisplayStudentsByClass();
                        break;
                    case 5:
                        DisplayAndWriteStudentsToFile();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStaff()
        {
            try
            {
                Console.Write("Enter Staff ID: ");
                int staffId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Staff Name: ");
                string staffName = Console.ReadLine();

                if (string.IsNullOrEmpty(staffName))
                {
                    throw new ArgumentNullException("StaffName", "Staff Name should not be Null");
                }

                if (staffs.Any(s => s.StaffId == staffId))
                {
                    throw new DuplicateStaffIdException("Staff ID Exists");
                }

                staffs.Add(new Staff { StaffId = staffId, StaffName = staffName });
                Console.WriteLine("Staff added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void AddStudent()
        {
            try
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Gender: ");
                string gender = Console.ReadLine();
                Console.Write("Enter Class: ");
                string studentClass = Console.ReadLine();
                Console.Write("Enter Section: ");
                string section = Console.ReadLine();
                Console.Write("Enter Staff Name: ");
                string staffName = Console.ReadLine();

                var staff = staffs.FirstOrDefault(s => s.StaffName == staffName);
                if (staff == null)
                {
                    throw new InvalidStaffNameException("Invalid Staff Name");
                }

                students.Add(new Student
                {
                    StudentID = students.Count + 1,
                    Name = name,
                    DOB = dob,
                    Gender = gender,
                    Class = studentClass,
                    Section = section,
                    StaffName = staffName
                });

                Console.WriteLine("Successfully added");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void DisplayStudentsByStaff()
        {
            try
            {
                Console.Write("Enter Staff Name: ");
                string staffName = Console.ReadLine();

                var studentsByStaff = students.Where(s => s.StaffName == staffName).ToList();

                if (!studentsByStaff.Any())
                {
                    Console.WriteLine("No students found for this staff.");
                    return;
                }

                foreach (var student in studentsByStaff)
                {
                    Console.WriteLine(student);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void DisplayStudentsByClass()
        {
            try
            {
                Console.Write("Enter Class: ");
                string studentClass = Console.ReadLine();

                var studentsByClass = students.Where(s => s.Class == studentClass).ToList();

                if (!studentsByClass.Any())
                {
                    Console.WriteLine("No students found for this class.");
                    return;
                }

                foreach (var student in studentsByClass)
                {
                    Console.WriteLine(student);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void DisplayAndWriteStudentsToFile()
        {
            string filePath = "students.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var student in students)
                    {
                        string studentInfo = student.ToString();
                        Console.WriteLine(studentInfo);
                        writer.WriteLine(studentInfo);
                        writer.WriteLine();
                    }
                }

                Console.WriteLine($"Students written to file {filePath} successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string StaffName { get; set; }

        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {Name}, DOB: {DOB.ToShortDateString()}, Gender: {Gender}, Class: {Class}, Section: {Section}, Staff: {StaffName}";
        }
    }

    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
    }

    public class DuplicateStaffIdException : Exception
    {
        public DuplicateStaffIdException(string message) : base(message) { }
    }

    public class InvalidStaffNameException : Exception
    {
        public InvalidStaffNameException(string message) : base(message) { }
    }
}
