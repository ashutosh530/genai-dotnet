using StudentManagement;

class Program
{
    public static void Main(string[] args)
    {
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


    }
}