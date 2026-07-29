using System;
using System.Security.Cryptography;
using StudentPro;
using CourseManagement;
using System.Reflection.Metadata.Ecma335;

class Program
{
    public static void Main(string[] args)
    {

        // Using Where
        List<int> numbers = new()
        {
            5,10,15,20,25,30,35,60
        };

        var lessNumbers = numbers.Where(n => n < 25);

        foreach (var number in lessNumbers)
        {
            Console.WriteLine($"Less Number is : {number}");
        }

        // Using Select
        List<string> names = new()
        {
            "Ashutosh",
            "Janms",
            "Tosy Sams",
            "Amit",
            "Mosay Jons"
        };
        // Count Length
        var countLater = names.Select(s => s.Length);
        foreach (var name in countLater)
        {
            Console.WriteLine(name);
        }
        // LowerCase
        var lowerLater = names.Select(n => n.ToLower());

        foreach (var lowerLat in lowerLater)
        {
            Console.WriteLine(lowerLat);
        }
        // Using OrderBy

        var alphabeticalOrder = names.OrderBy(n => n);
        foreach (var alphabetical in alphabeticalOrder)
        {
            Console.WriteLine(alphabetical);
        }

        // Using Method Chaining
        List<int> chainingNum = new()
        {
            40,20,30,25,34,28
        };

        var chaningNums = chainingNum.Where(n => n > 20).OrderBy(n => n);
        foreach (var chainingNumByOrder in chaningNums)
        {
            Console.WriteLine(chainingNumByOrder);
        }

        List<string> nameList = new()
        {
          "Ashutosh",
          "Rahul",
            "Amit",
            "Priya",
            "Ankit"
        };

        // var result = nameList.Where( n => n.StartsWith("A")).OrderBy(n => n).Select(n => n.ToUpper()).First();
        var result = nameList
     .Select(n => n.ToUpper())
     .Where(n => n.StartsWith("A"))
     .First();
        Console.WriteLine(result);

        List<Student> students = new()
        {
            new Student { Id = 1, Name = "Ashutosh", Marks = 80, Department = "Computer" },
            new Student { Id = 2, Name = "Rahul", Marks = 60, Department = "IT" },
            new Student { Id = 3, Name = "Amit", Marks = 92, Department = "Computer" },
            new Student { Id = 4, Name = "Priya", Marks = 70, Department = "IT" },
            new Student { Id = 5, Name = "Ankit", Marks = 95, Department = "Computer" },
            new Student { Id = 6, Name = "Neha", Marks = 85, Department = "AI" }
        };

        var finalResult = students.Where(s => s.Marks >= 70).Select(s => s.Name).OrderBy(n => n);
        foreach (var res in finalResult)
        {
            Console.WriteLine(res);
        }

        // Is there any student whose name starts with "B"?
        bool startWithB = students.Any(s => s.Name.StartsWith("B"));
        Console.WriteLine(startWithB);

        // Print the names of students who scored 80 or more, sorted in descending alphabetical order.
        var scored80 = students.Where(s => s.Marks >= 80).Select(s => s.Name).OrderByDescending(s => s);
        foreach (var storeScored80 in scored80)
        {
            Console.WriteLine(storeScored80);
        }

        // Using Distinct
        List<string> namesDis = new()
        {
            "Ashutosh",
            "Rahul",
            "Ashutosh",
            "Amit",
            "Rahul",
            "Priya",
            "Amit"
        };
        var resultDistinct = namesDis.Distinct();
        foreach (var uniqueNames in result)
            Console.WriteLine(uniqueNames);

        // Using Contains()
        bool nameContain = namesDis.Contains("Rohit");
        Console.WriteLine(nameContain);

        // Using Take()

        var numbersTake = numbers.Take(2);
        foreach (var numTake in numbersTake)
            Console.WriteLine(numTake);

        // Using Skip
        var numbersSkip = numbers.Skip(3);
        foreach (var numSkip in numbersSkip)
            Console.WriteLine(numSkip);

        // Using Sum
        var totalMarks = students.Where(n => n.Marks >= 70).Sum(m => m.Marks);
        Console.WriteLine(totalMarks);

        // Using Average
        var averageMark = students.Where(m => m.Marks >= 70).Average(s => s.Marks);
        Console.WriteLine(averageMark);

        // Using Max or Min
        var highestMark = students.Max(s => s.Marks);
        Console.WriteLine(highestMark);

        var lowestMark = students.Min(s => s.Marks);
        Console.WriteLine(lowestMark);

        var scored80Names = students.Where(s => s.Marks >= 80).Select(n => n.Name).OrderBy(s => s);
        foreach (var namesAlpha in scored80Names)
            Console.WriteLine(namesAlpha);

        // Start Advance LINQ, using GroupBy or Count

        var groupedDepartment = students.GroupBy(s => s.Department);

        foreach (var department in groupedDepartment)
        {
            Console.WriteLine($"Department : {department.Key} -> {department.Count()}");
            foreach (var student in department)
                Console.WriteLine(student.Name);
        }
        // Using GroupBy + Average 

        var markInDepartment = students.GroupBy(d => d.Department);
        foreach (var markDepartment in markInDepartment)
        {
            Console.WriteLine($"{markDepartment.Key} -> {markDepartment.Average(m => m.Marks)} ");

        }

        // Using GroupBy + Where
        var departmentAvgGrater70 = students.GroupBy(d => d.Department);
        foreach (var depAvgGra70 in departmentAvgGrater70)
        {
            var avgGra70 = depAvgGra70.Average(m => m.Marks);
            if (avgGra70 >= 70)
            {
                Console.WriteLine($"{depAvgGra70.Key} -> {avgGra70}");
            }
        }

        // Using Join 
        Console.WriteLine("========= Using Join ===========");

        List<Course> courses = new()
        {
            new Course { StudentId =1, CourseName ="C#"},
            new Course { StudentId = 2, CourseName = "ASP.NET Core" },
            new Course { StudentId = 3, CourseName = "AI/ML" }
        };

        var courseResult = students.Join(
            courses,
            students => students.Id,
            courses => courses.StudentId,
            (students, courses) => new
            {
                students.Name,
                students.Marks,
                courses.CourseName
            }
        );

        foreach (var resultJoin in courseResult)
        {
            Console.WriteLine($"{resultJoin.Name} -> {resultJoin.CourseName}");
        }

        var courseResultFilter = students.Join(
        courses,
        student => student.Id,
        course => course.StudentId,
        (student, course) => new
        {
            student.Name,
            student.Marks,
            course.CourseName
        })
       .Where(x => x.Marks >= 80);

        foreach (var resultFilter in courseResultFilter)
        {
            Console.WriteLine($"{resultFilter.Name} -> {resultFilter.CourseName}");
        }
          // using SelectMany()
        var resultSelectMany = courses.SelectMany(s => s.CourseName).Distinct();
        Console.WriteLine("----- SelectMany() -------");
        foreach (var resultMany in resultSelectMany)
        {
            Console.WriteLine(resultMany);
        }

        // using SelectMany() + Distinct()
        var resultSelectManyDis = courses.SelectMany(s => s.CourseName).Distinct();
        Console.WriteLine("----- SelectMany() + Distinct () -------");
        foreach (var resultMany in resultSelectManyDis)
        {
            Console.WriteLine(resultMany);
        }

        // Using ToDictionary
       // var studentDictionary = students.ToDictionary(s => s.Id, s => s.Name);
       
       var studentDictionary = students.ToDictionary(s => s.Id, s => s.Name);
       foreach( var studentDictionaryMark in studentDictionary)
       Console.WriteLine(studentDictionaryMark);

        // Using Distionary + Where
       var studentDictionaryFilter = students.Where(m => m.Marks >= 80).ToDictionary(s => s.Id, s => s.Name);
       foreach( var studentDictionaryMarkFilter in studentDictionaryFilter)
       Console.WriteLine(studentDictionaryMarkFilter);

       // LINQ Query Syntax 

       var resultQuery = 
       from s in students 
       where  s.Marks >= 70
       orderby s.Name
       select s.Name;
       foreach( var result70 in resultQuery)
        {
            Console.WriteLine(result70);
        }

        // Query Syntax + GroupBy
        var groupedQuery = 
        from s in students
        group s by s.Department;

        foreach( var gorupedDepartment in groupedQuery)
        {
            Console.WriteLine(gorupedDepartment.Key);
            foreach( var studentQuery in gorupedDepartment)
            {
                Console.WriteLine(studentQuery.Name);
            }
        }

        // Deferred Execution

        // Group students by department and find the highest marks in each department.

        var highestMarks = students.GroupBy( s => s.Department);

        foreach (var resultHighest in highestMarks)
        {
            Console.WriteLine($"{resultHighest.Key} -> {resultHighest.Max(s => s.Marks)}");
        }

        // Find the average marks for each department, but display only departments whose average is 70 or greater, sorted by the average marks from highest to lowest.

       var averageMarks = students
    .GroupBy(s => s.Department)
    .OrderByDescending(group => group.Average(s => s.Marks));

        foreach (var eachDepartment in averageMarks)
        {
            var average700 = eachDepartment.Average(s => s.Marks);

            if (average700 >= 70)
            {
                Console.WriteLine("------");
                Console.WriteLine($"{eachDepartment.Key} -> {average700}");
            }
        }

        var departmentAverage70 = students.GroupBy( s => s.Department)
        .OrderByDescending( g => g.Average( m => m.Marks));

        Console.WriteLine("---- Highest ----");
        foreach( var departmentAvgHighest in departmentAverage70)
        {
            
            var avgHighestMarks = departmentAvgHighest.Average( h => h.Marks);
            if(avgHighestMarks >= 70)
            {
                Console.WriteLine($"{departmentAvgHighest.Key} -> {avgHighestMarks}");
            }
        }
    }
}