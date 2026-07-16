
using System;
using Box;
using PairsManage;
using RepositoryManagement;
 class Program
{
    public static void Main()
    {
        // For Box Data
        var intBox = new BoxData<int>(123);
        var stringBox = new BoxData<string>("Hello, Generics");

        Console.WriteLine(intBox);
        Console.WriteLine(stringBox);

        Console.WriteLine(intBox.Value);
        Console.WriteLine(stringBox.Value);

        // For Pairs Data 

        Pair<int, string> pairs = new Pair<int, string>(101, "Pihu");
        Console.WriteLine(pairs);

        // For Repository

        Repository<Student> repo = new Repository<Student>();

        repo.Add(new Student {Id = 1001, Name = "Shivang", Class = 1});
        repo.Add(new Student {Id = 1002, Name = "Abha", Class = 10});

        repo.DisplayAll();
        
        Console.WriteLine($"Total Number of Students : {repo.Count()}");
        Console.WriteLine();
       Repository<Employee> repository = new Repository<Employee>();

       repository.Add(new Employee {Id = 101, Name = "Toky Thomos"});
       repository.Add(new Employee { Id = 102, Name = "Massy Gool"});

       repository.DisplayAll();

       Console.WriteLine($"Total Number of Employee : {repository.Count()}");


    }
}