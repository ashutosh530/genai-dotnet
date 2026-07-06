using System;

namespace AnimalManagement
{
abstract class Animal
{
    public int Id{get; set;}
    public string Name {get; set;}

    public int age {get; set;}

    public Animal(int id, string name, int age)
    {
        Id =id;
        Name = name;
        this.age = age;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {age}");
    }
    public abstract void MakeSound();

}
 class Dog : Animal
{
    public Dog(int id, string name, int age) : base(id, name, age)
    {
        
    }
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Cat : Animal
{
    public Cat(int id, string name, int age) : base(id, name, age)
    {
        
    }
    public override void MakeSound()
    {
        Console.WriteLine("Cat Meows");
    }
}
}