using StudentManagement;
using EmployeeManagement;

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

    }
}