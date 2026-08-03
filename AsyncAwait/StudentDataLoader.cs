using System;

namespace StudentDataLoader
{
    public class Student
    {

        public async Task<string> GetStudentAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Student Information Loaded");
            return "John Deo";
        }

        public async Task<string> GetStudentCourseAsync()
        {
            await Task.Delay(3000);
            Console.WriteLine("Student Course Loaded");
            return "Computer Science";
        }

        public async Task<int> GetStudentFeeAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Student Fee Loaded");
            return 1000;
        }
    }
}