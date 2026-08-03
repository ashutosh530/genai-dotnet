using System;
using System.Runtime.CompilerServices;
using StudentDataLoader;

class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting the program...");

        await Task.Delay(3000); // Simulate some asynchronous work
        Console.WriteLine("Program completed.");

        string name = await AsyncTest.GetStudentNameAsync();
        Console.WriteLine($"Student Name: {name}");

        // Running independent tasks concurrently
        Task task1 = Task.Delay(3000);
        Task task2 = Task.Delay(2000);

        await Task.WhenAll(task1, task2);
        Console.WriteLine("Both tasks completed.");
        
        // Student Data Loader
        try
        {
            Student student = new Student();

            Task<string> studentNameTask = student.GetStudentAsync();
            Task<string> studentCourseTask = student.GetStudentCourseAsync();
            Task<int> studentFeeTask = student.GetStudentFeeAsync();

            await Task.WhenAll(studentNameTask, studentCourseTask, studentFeeTask);

            Console.WriteLine($"Student Name: {await studentNameTask}");
            Console.WriteLine($"Student Course: {await studentCourseTask}");
            Console.WriteLine($"Student Fee: {await studentFeeTask}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }


    }



}

class AsyncTest
{
    public static async Task<string> GetStudentNameAsync()
    {
        await Task.Delay(3000); // Simulate an asynchronous operation
        return "John Deo";
    }

}
