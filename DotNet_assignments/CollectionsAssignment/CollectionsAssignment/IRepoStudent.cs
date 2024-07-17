using System;
using System.Collections.Generic;

namespace Assignment4
{
    interface IRepository
    {
        void AddStudent(StudentDetails student);
        List<StudentDetails> GetAllStudents();
        StudentDetails GetStudent(int id);
        void RemoveStudent(int id);
        void UpdateStudent(StudentDetails student);
    }

    class StudentRepository : IRepository
    {
        List<StudentDetails> studentDetails = new List<StudentDetails>();

        public void AddStudent(StudentDetails student)
        {
            studentDetails.Add(student);
        }

        public List<StudentDetails> GetAllStudents()
        {
            return studentDetails;
        }

        public StudentDetails GetStudent(int id)
        {
            foreach (StudentDetails student in studentDetails)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public void RemoveStudent(int id)
        {
            StudentDetails studentToRemove = null;
            foreach (StudentDetails student in studentDetails)
            {
                if (student.Id == id)
                {
                    studentToRemove = student;
                    break;
                }
            }
            if (studentToRemove != null)
            {
                studentDetails.Remove(studentToRemove);
            }
        }

        public void UpdateStudent(StudentDetails student)
        {
            for (int i = 0; i < studentDetails.Count; i++)
            {
                if (studentDetails[i].Id == student.Id)
                {
                    studentDetails[i].Name = student.Name;
                    studentDetails[i].Branch = student.Branch;
                }
            }
        }
    }

   

    internal class IRepoStudent
    {
        static void Main()
        {
            StudentRepository studentRepository = new StudentRepository();
            try
            {
                do
                {
                    Console.WriteLine("1. Add\n2. GetById\n3. GetAll\n4. Update\n5. Delete\n6. Exit");
                    Console.WriteLine("Select Option");
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            {
                                StudentDetails studentDetails = new StudentDetails();
                                studentDetails.Id = new Random().Next();
                                Console.WriteLine("Enter Your name");
                                studentDetails.Name = Console.ReadLine();
                                Console.WriteLine("Enter your branch");
                                studentDetails.Branch = Console.ReadLine();
                                studentRepository.AddStudent(studentDetails);
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter Student Id");
                                int id = int.Parse(Console.ReadLine());
                                StudentDetails studentDetails = studentRepository.GetStudent(id);
                                if (studentDetails != null)
                                {
                                    Console.WriteLine(studentDetails.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("Invalid id");
                                }
                                break;
                            }

                        case 3:
                            {
                                List<StudentDetails> studentDetails = studentRepository.GetAllStudents();
                                if (studentDetails.Count > 0)
                                {
                                    foreach (var item in studentDetails)
                                    {
                                        Console.WriteLine(item.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("List is empty");
                                }
                            }
                            break;

                        case 4:
                            {
                                StudentDetails studentDetails = new StudentDetails();
                                Console.WriteLine("Enter id of the user");
                                studentDetails.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Name");
                                studentDetails.Name = Console.ReadLine();
                                Console.WriteLine("Enter Branch");
                                studentDetails.Branch = Console.ReadLine();
                                studentRepository.UpdateStudent(studentDetails);
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Enter student id");
                                int id = int.Parse(Console.ReadLine());
                                studentRepository.RemoveStudent(id);
                            }
                            break;
                        case 6:
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
