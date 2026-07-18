using System;
using StudentServices;

class Program
{
    public static void Main(string[] args)
    {
        StudentService studentService = new StudentService();

        while (true)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Student Management System");
            Console.WriteLine("==============================");
            Console.WriteLine();

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");

            Console.WriteLine();
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    studentService.AddStudent();
                    break;

                case 2:
                    studentService.GetAllStudents();
                    break;

                case 3:
                    studentService.SearchStudentById();
                    break;

                case 4:
                    studentService.UpdateStudent();
                    break;

                case 5:
                    studentService.DeleteStudent();
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}