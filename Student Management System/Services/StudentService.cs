using System;
using System.Runtime.CompilerServices;
using Students;
using StudentRepository;
using Microsoft.VisualBasic;

namespace StudentServices
{
 class StudentService
    {
        private Repository<Student> _repository;
        public StudentService()
        {
            _repository = new Repository<Student>();
        }

        public void AddStudent()
        {

            Console.WriteLine("Enter the Student Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Student Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Student Class");
            int studentClass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Student Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Student student = new Student();
            student.Id = id;
            student.Name = name;
            student.Class = studentClass;
            student.Age = age;

            _repository.Add(student);
            Console.WriteLine("Student is successfully added.");
        }

        public void GetAllStudents()
        {

            var students = _repository.GetAll();
            if (students.Count > 0)
            {
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }

            }
            else
            {
                Console.WriteLine("Student list is empty.");
            }

        }

        public void SearchStudentById()
        {
            Console.WriteLine("Enter the Student Id");
            int id = Convert.ToInt32(Console.ReadLine());

            var studentId = _repository.GetAll();
            bool found = false;

            foreach (var student in studentId)
            {
                if (student.Id == id)
                {
                    Console.WriteLine(student);
                    found = true;
                    break;
                }
            }
            if (!found)
                Console.WriteLine("Student is not found.");
        }

        public void UpdateStudent()
        {
            // For seraching student by Id
            Console.WriteLine("Enter the Student Id");
            int id = Convert.ToInt32(Console.ReadLine());
            // For student all list
            var students = _repository.GetAll();
            bool found = false;


            foreach (var student in students)
            {
                if (student.Id == id)
                {

                    Console.WriteLine("Enter the New Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the New Class");
                    int studentClass = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the New Age");
                    int studentAge = Convert.ToInt32(Console.ReadLine());

                    student.Name = name;
                    student.Class = studentClass;
                    student.Age = studentAge;

                    Console.WriteLine("Student upadate Successfully.");

                    found = true;
                    break;

                }

            }
            if (!found)
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DeleteStudent()
        {
            Console.WriteLine("Enter the student Id");
            int id = Convert.ToInt32(Console.ReadLine());

            var students = _repository.GetAll();
            bool found = false;
            Student studentToDelete = null;

            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    studentToDelete = student;
                    found = true;
                    break;
                }
            }
            if (studentToDelete != null)
            {
                _repository.Remove(studentToDelete);
                Console.WriteLine("Student is deleted successfully.");
            }
            else
            {
                Console.WriteLine("Studnet not found");
            }


        }
    }
}