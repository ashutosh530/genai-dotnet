using System;
using System.Collections.Generic;
using EmployeeDic;

namespace EmployeeManagerDic
{
    class EmployeeManagerDict
    {
        private Dictionary<int, string> _employees;

        public EmployeeManagerDict()
        {
            _employees = new Dictionary<int, string>();
        }

        public void AddEmployees(int id, string name)
        {
            if (!_employees.ContainsKey(id))
            {
                _employees.Add(id, name);
                Console.WriteLine($"Added: ID :- {id} - Name :-  {name}");
            }
            else
            {
                Console.WriteLine($"Error : Id is {id} already exists.");
            }
        }

        public string GetEmployeeById(int Id)
        {
            if(_employees.TryGetValue(Id, out string name))
            {
                return name;
            }
            return "Employee not found...";
        }

        // Upadete Employee
        public void UpdateEmployee(int id, string newName)
        {
            if (_employees.ContainsKey(id))
            {
                _employees[id] = newName;
                Console.WriteLine($"Employee ID {id} updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee Not Found.");
            }
        }
        // Remove Employee
        public void RemoveEmployees(int id)
        {
            if (_employees.Remove(id))
            {
                Console.WriteLine($"Employee ID {id} removed successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // Display All Employee
        public void DisplayEmployee()
        {
            if(_employees.Count == 0)
            {
                Console.WriteLine("No Employee Available.");
            }
            Console.WriteLine("\nEmployee List");

            foreach(KeyValuePair<int, string> emp in _employees)
            {
                Console.WriteLine($"Id : {emp.Key} Name : {emp.Value}");
            }
        }

        public void CountEmployee()
        {
            Console.WriteLine($"Total Employee : {_employees.Count}");
        }
    }
}

