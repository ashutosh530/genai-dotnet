using System;
namespace StudentApp
{
    public class Student
    {
        public void DisplayInfo(string name)
        {
            Console.WriteLine($"Student Name: {name}");
        }

        public void DisplayInfo(string name, int age)
        {
            Console.WriteLine($"Student Name: {name}, Age:{age}");
        }

        public void DisplayInfo(string name, int age, string grade)
        {
            Console.WriteLine($"Student Name: {name}, Age:{age}, Grade:{grade}");
        }
    }
}