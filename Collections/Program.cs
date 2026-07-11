using StudentManagement;
using EmployeeManagement;
using BrowserHistoryManage;
using PageBH;

class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of StudentManager
        StudentManager studentManager = new StudentManager();

        // Adding students
        studentManager.AddStudent(new Student(1, "Alice", 101, "10th Grade"));
        studentManager.AddStudent(new Student(2, "Bob", 102, "11th Grade"));
        studentManager.AddStudent(new Student(3, "Charlie", 103, "12th Grade"));

        // Displaying all students
        Console.WriteLine("All Students:");
        foreach (var student in studentManager.GetAllStudents())
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Roll Number: {student.RollNumber}, Class: {student.Class}");
        }

        // Counting students
        studentManager.CountStudents();

        // Removing a student
        studentManager.RemoveStudent(2);

        // Displaying all students after removal
        Console.WriteLine("\nAll Students after removal:");
        foreach (var student in studentManager.GetAllStudents())
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Roll Number: {student.RollNumber}, Class: {student.Class}");
        }

        // Searching for a student
        var searchedStudent = studentManager.GetStudent(1);
        if (searchedStudent != null)
        {
            Console.WriteLine($"\nSearched Student: ID: {searchedStudent.Id}, Name: {searchedStudent.Name}, Roll Number: {searchedStudent.RollNumber}, Class: {searchedStudent.Class}");
        }
        else
        {
            Console.WriteLine("\nStudent not found.");
        }

        // Creating an instance of EmployeeManager using Queue
        EmployeeManager employeeManager = new EmployeeManager();
        employeeManager.AddEmployee(new Employee(1, "John Doe", "HR"));
        employeeManager.AddEmployee(new Employee(2, "Jane Smith", "Finance"));
        employeeManager.AddEmployee(new Employee(3,"Thor", "Engineering"));

        // Displaying the first employee in the queue
        var firstEmployee = employeeManager.GetEmployee();
        if (firstEmployee != null)
        {
            Console.WriteLine($"\nFirst Employee in Queue: ID: {firstEmployee.Id}, Name: {firstEmployee.Name}, Department: {firstEmployee.Department}");
        }
        else
        {
            Console.WriteLine("\nNo employees available.");
        }

        // Updating the first employee in the queue
        employeeManager.UpadateEmployee(1, "John Updated", "HR Updated");

        // Displaying the updated first employee in the queue
        var updatedEmployee = employeeManager.GetEmployee();
        if (updatedEmployee != null)
        {
            Console.WriteLine($"\nUpdated First Employee in Queue: ID: {updatedEmployee.Id}, Name: {updatedEmployee.Name}, Department: {updatedEmployee.Department}");
        }
        else
        {
            Console.WriteLine("\nNo employees available.");
        }

        // Removing the first employee from the queue
        employeeManager.RemoveEmployee();
        // Displaying the first employee in the queue after removal
        var nextEmployee = employeeManager.GetEmployee();
        if (nextEmployee != null)
        {
            Console.WriteLine($"\nNext Employee in Queue after removal: ID: {nextEmployee.Id}, Name: {nextEmployee.Name}, Department: {nextEmployee.Department}");
        }
        else
        {
            Console.WriteLine("\nNo employees available.");
        }
        
         // Creating an instance of Browser History Project using Stack

         BrowserHistory browserHistory = new BrowserHistory();

         browserHistory.VisitPage(new Page(1,"Youtube","https://youtube.com"));
         browserHistory.VisitPage(new Page (2,"Google","https://google.com"));
         browserHistory.VisitPage(new Page (3, "ChatGpt", "https://chatgpt.com"));

         browserHistory.CountPage();
        Page current =  browserHistory.GetCurrentPage();
        if(current != null)
        {
            Console.WriteLine($"{current.Title}");
        }
         browserHistory.GoBack();
         
        

    }
}