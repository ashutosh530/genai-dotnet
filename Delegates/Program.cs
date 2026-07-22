using System;
using System.Security.Cryptography.X509Certificates;
using DelegateSystem;


class Program
{
    public delegate void MyDelegate();
    public delegate int VarDelegate(int a, int b);
    static void SayHello()
    {
        Console.WriteLine("Hello, Ashutosh");
    }
    static void Intro()
    {
        Console.WriteLine("I am Ashutosh Singh");
    }

    // ReturnDelegate
    static int Add(int a, int b) => (a+b);
    static int Multiply(int a, int b) => (a*b);
    public static void Main(string[] arg)
    {
        MyDelegate myDelegate = SayHello;
        MyDelegate intro = Intro;
        myDelegate();
        intro();

        // ReturnDelegate

        VarDelegate var = Add;
        Console.WriteLine("Addition : " + var(3,6));
        var = Multiply;
        Console.WriteLine("Multiply : " + var (5,6));

    }
}