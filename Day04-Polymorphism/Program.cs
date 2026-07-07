using System;
using CalculatorApp;
using StudentApp;
using EmployeeManagement;
using AnimalManagement;
using PaymentApp;
using NotificationApp;

class Program
{
    static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        cal.Add(2,4);
        cal.Add(2, 4, 6);
        cal.Add(2.5,5.3);   

        Student student = new Student();
        student.DisplayInfo("John");
        student.DisplayInfo("John", 20);    
        student.DisplayInfo("John", 20, "A");


        Employee employee = new Developer(5, "Alice", 50000, "C#");
        employee.Work();
        employee.ShowDetails();

        Developer developer = new Developer(1, "Alice", 50000, "C#");
        developer.ShowDetails();
        developer.WriteCode();
        developer.Work();

         Manager manager = new Manager(2, "John", 50000, 20);
        manager.ShowDetails();
        manager.ConductMeeting();
        manager.Work();

        Tester tester = new Tester(3, "Meli", 50000, "Selenium");
        tester.ShowDetails();
        tester.TestApplications();
        tester.Work();

        // Using Abstractions  for Animal Management

        Animal dog = new Dog(1, "Buddy", 3);
        dog.ShowDetails();
        dog.MakeSound();

        Animal cat = new Cat(2, "Whiskers", 5);
        cat.ShowDetails();
        cat.MakeSound();

        // Using Abstractions for Payment Management
        Console.WriteLine("\n-----Payment Management System-----\n");

        Payment upiPayment = new UPIPayment(1, DateOnly.FromDateTime(DateTime.Now), 1000, "upi_id_123");
        upiPayment.ShowPaymentDetails();
        upiPayment.ProcessPayment();
        upiPayment.ValidatePayment();

        Payment creditCardPayment = new CreditCardPayment(2, DateOnly.FromDateTime(DateTime.Now), 2000, "1234567890123456", 123, DateOnly.FromDateTime(DateTime.Now.AddYears(2)));
        creditCardPayment.ShowPaymentDetails();
        creditCardPayment.ProcessPayment();
        creditCardPayment.ValidatePayment();

        Payment netBankingPayment = new NetBankingPayment(3, DateOnly.FromDateTime(DateTime.Now), 3000, "HDFC Bank", "account_123");
        netBankingPayment.ShowPaymentDetails();
        netBankingPayment.ProcessPayment();
        netBankingPayment.ValidatePayment();

        // Using Interface for Notification Management
        Console.WriteLine("\n-----Interface Notification Management System-----\n");
        INotificationSender emailSender = new EmailNotificationSender();
        emailSender.SendNotification("Sending Email Notification...");

        INotificationSender smsSender = new SMSNotificationSender();
        smsSender.SendNotification("Sending SMS Notification...");

        INotificationSender pushSender = new PushNotificationSender();
        pushSender.SendNotification("Sending Push Notification...");


    
    }
    
}
