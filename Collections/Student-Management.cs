using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public string Class { get; set; }

        public Student(int id, string name, int rollNumber, string studentClass)
        {
            Id = id;
            Name = name;
            RollNumber = rollNumber;
            Class = studentClass;
        }

    }

    public class StudentManager
    {
        private List<Student> students;

        public StudentManager()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(int id)
        {
            students.RemoveAll(s => s.Id == id);
        }

        public Student GetStudent(int id)
        {
            return students.Find(s => s.Id == id);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public void CountStudents()
        {
            Console.WriteLine($"Total number of students: {students.Count}");
        }
    }
}