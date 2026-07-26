using System;
using StudentPro;

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
          new Student {Id =1, Name = "Baby Johns", Marks = 80},
          new Student {Id = 2, Name = "Shree", Marks = 60},
          new Student { Id = 3, Name = "Amit", Marks = 92 },
          new Student { Id = 4, Name = "Priya", Marks = 70 },
          new Student { Id = 5, Name = "Ankit", Marks = 95 }
        };

        var finalResult = students.Where( s => s.Marks >= 70).Select( s => s.Name).OrderBy(n => n);
        foreach(var res in finalResult)
        {
            Console.WriteLine(res);
        }

        // Is there any student whose name starts with "B"?
        bool startWithB = students.Any( s => s.Name.StartsWith("B"));
        Console.WriteLine(startWithB);

        // Print the names of students who scored 80 or more, sorted in descending alphabetical order.
        var scored80= students.Where( s => s.Marks >= 80).Select(s => s.Name).OrderByDescending( s => s);
        foreach(var storeScored80 in scored80)
        {
            Console.WriteLine(storeScored80);
        }

    }
}