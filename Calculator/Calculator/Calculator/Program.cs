using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the amazing addition solver!");
            Console.WriteLine("Please enter your first number!");
            var firstNumber = Console.ReadLine();

            Console.WriteLine("Please enter your second number!");
            var secondNumber = Console.ReadLine();

            Console.WriteLine($"Performing the addition operation between {firstNumber} and {secondNumber}");

            var answer = 0;

            Console.WriteLine($"And the answer is {answer}");

            Console.ReadLine();
        }
    }
}
