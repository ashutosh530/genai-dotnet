using System;

namespace CalculatorApp
{
  public class Calculator
    {

        public int Add(int FirstNumber, int SecondNumber)
        {
            int sum = FirstNumber + SecondNumber;
            Console.WriteLine($"The sum of {FirstNumber} and {SecondNumber} is: {sum}");
            return sum;
        }
        public int Add(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            int sum = FirstNumber + SecondNumber + ThirdNumber;
            Console.WriteLine($"The sum of {FirstNumber}, {SecondNumber}, and {ThirdNumber} is: {sum}");
            return sum;
        }

        public double Add(double DeciFirst, double DeciSecond)
        {
            double sum = DeciFirst + DeciSecond;
            Console.WriteLine($"The sum of {DeciFirst} and {DeciSecond} is: {sum}");
            return sum;
        }
    }
}