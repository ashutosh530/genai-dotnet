using System;

namespace Students
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id - {Id}, Name - {Name}, Class - {Class}, Age - {Age} ";
        }
    }
}