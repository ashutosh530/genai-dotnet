using System;
using EmployeeManagementSystem;
//Constructor in Inheritance

// class Employee
// {
//     public Employee()
//     {
//         Console.WriteLine("Employee Constructor");
//     }
// }

//  class Developer : Employee
// {
//     public Developer()
//     {
//         Console.WriteLine("Developer Constructor");
//     }
// }

class Program
{
    static void Main(string[] args)
    {
       // Developer dev = new Developer();

        Developer dev = new Developer(101, "Pawan Singh", 50000, "PHP");
        dev.ShowDetails();
        dev.WriteCode();

        Manager mng = new Manager(103,"Ashu Singh",6000,20);
        mng.ShowDetails();
        mng.ConductMeeting();   

        Tester tester = new Tester(102,"John Deo",4000,"Seleniuem");
        tester.ShowDetails();
        tester.TestApplications();
    }
}
// class Employee
// {
//     public int Id;
//     public string Name;

//     public void ShowEmployee()
//     {
//         Console.WriteLine($"Id: {Id}");
//         Console.WriteLine($"Name: {Name}");
//     }
// }

// class Developer: Employee
// {
//     public string Technology;
//     public void ShowDeveloper()
//     {
//        Console.WriteLine($"{Name} is writing {Technology}"); 
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Developer dev = new Developer();

//         dev.Id =1;
//         dev.Name = "John Deo";
//         dev.Technology = "C#";

//         dev.ShowEmployee();
//         dev.ShowDeveloper();
//     }
// }