using System;

namespace EmployeeManagementSystem
{
    class Employee
    {
        private double Salary;

        public int Id {get; set;}
        public string Name {get; set;}
        public double salary
        {
            get{return Salary;}
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Salary cannot be negative");
                }
                else
                {
                    Salary = value;
                }
            }
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            this.salary = salary;
        }      

        public void ShowDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {salary}");
        }

    }
    class Developer : Employee
    {
        public string Technology {get; set;}

        public Developer(int id, string name, double salary, string technology) : base(id, name, salary)
        {
            Technology = technology;
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing in {Technology}");
        }
    }

    class Manager : Employee
    {
        public int TeamSize {get; set;}

        public Manager(int id, string name, double salary, int teamSize) : base(id, name, salary)
        {
            TeamSize = teamSize;
        } 

        public void ConductMeeting()
        {
            Console.WriteLine($"{Name} is conducting meeting with team size {TeamSize}");
        }

    }

    class Tester : Employee
    {
        public string TestingTools{get; set;}

        public Tester(int id, string name, double salary, string testingTools) : base(id, name, salary)
        {
            TestingTools = testingTools;
        }

        public void TestApplications()
        {
            Console.WriteLine($"It's a {Name} Tester and using {TestingTools} tools for testing applications");
        }
    }

}

