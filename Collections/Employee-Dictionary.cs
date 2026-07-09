using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }
    }

    class EmployeeManager
    {
        private Queue<Employee> employee;

        public EmployeeManager()
        {
            employee = new Queue<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            employee.Enqueue(emp);
        }

        public void RemoveEmployee()
        {
            if (employee.Count > 0)
            {
                employee.Dequeue();
            }
            else
            {
                Console.WriteLine("No employees to remove.");
            }
        }

        public Employee GetEmployee()
        {
            if (employee.Count > 0)
            {
                return employee.Peek();
            }
            else
            {
                Console.WriteLine("No employees available.");
                return null;
            }
        }

        public void UpadateEmployee(int id, string name, string department)
        {
            Employee emp = employee.Peek();
            if(emp != null && emp.Id == id)
            {
                emp.Name = name;
                emp.Department = department;
            }
            else
            {
                Console.WriteLine("Employee not found or queue is empty.");
            }
            
        }

    }
}