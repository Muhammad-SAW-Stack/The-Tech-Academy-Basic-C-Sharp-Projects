using MainMethodAssignment;
using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code instantiates the class.
            MathOperations operations = new MathOperations();
            // Calls the method that takes an integer and displays the result.
            int result1 = operations.Calculate(5);
            // Prints to the screen "Result 1: 'result'".
            Console.WriteLine("Result 1: " + result1);
            // Calls the method that takes a decimal and displays the result.
            int result2 = operations.Calculate(5.5m);
            // Prints to the screen "Result 2: 'result2'".
            Console.WriteLine("Result 2: " + result2);
            // Calls the method that takes a string and displays the result.
            int result3 = operations.Calculate("15");
            // Prints to the screen "Result 3: 'result3'".
            Console.WriteLine("Result 3: " + result3);
        }
    }
}