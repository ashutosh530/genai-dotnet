using System;
using Microsoft.VisualBasic;

namespace ExceptionsHandling
{
    class Exceptions
    {
        public void ErrorsMessage()
        {
            try
            {
                Console.WriteLine("Inside Try");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }

            try
            {
                Console.WriteLine("Line 1");

                int number = int.Parse("ABC");

                Console.WriteLine("Line 2");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch Block");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }

            Console.WriteLine("Program Finished");



            try
            {
                Console.WriteLine("1");

                int a = 10;
                int b = 0;

                Console.WriteLine(a / b);

                Console.WriteLine("2");
            }
            catch (Exception ex)
            {
                Console.WriteLine("3");
            }
            finally
            {
                Console.WriteLine("4");
            }

            Console.WriteLine("5");

            // throw

            try
            {
                int age = -5;

                if (age < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }

                Console.WriteLine("Valid Age");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Multiple catch Blocks

            try
            {
                int number = int.Parse("ABC");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred.");
            }

            // Custom Exceptions

            var withdrawAmount = 500;
            var balance = 300;
            if (withdrawAmount > balance)
            {
                throw new InsufficientBalanceException(
                    "Insufficient account balance."
                );
            }


        }
    }

    // Custom Exceptions Class

    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message)
            : base(message)
        {
        }
    }

}