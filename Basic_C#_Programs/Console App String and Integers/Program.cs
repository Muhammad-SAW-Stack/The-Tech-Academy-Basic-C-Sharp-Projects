using System;
using System.Collections.Generic;

namespace Console_App_String_and_Integers 
{


    class Program
    {
        private static void Main(string[] args)
        {
            // Creates a list of integers called "numbers" that consists of the integers 24, 6, 14, 19, 88.
            List<int> numbers = new List<int> { 34, 6, 14, 19, 88 };
            // Prints to the screen "Enter a number to divide by: ".
            Console.Write("Enter a number to divide by: ");
            // Saves the users input.
            string input = Console.ReadLine();
            // A try block in C# is a block of code where exceptions may occur and can be caught and handled by a corresponding catch block.
            try
            {
                // Converts the user input to an integer.
                int divisor = int.Parse(input);
                // The "foreach" keyword is used to start the loop. "Foreach" are Loops that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                // The "in" keyword is used to separate the type and variable from the collection being iterated over.
            foreach (int number in numbers)
            {
                // Integer "result" is "number" divided by "divisor". 
                int result = number / divisor;
                // Prints to the screen "'number' divided by 'divisor' is 'result'".
                Console.WriteLine(number + " divided by " + divisor + " is " + result);
            }
            }
            // In C#, a catch block is used in conjunction with a try block to handle exceptions. If an exception occurs within the try block,
            // control is transferred to the catch block, where the exception can be handled.
            catch (DivideByZeroException)
            {
                // Prints to the screen "Cannot divide by zero".
                Console.WriteLine("Cannot divide by zero.");
            }
            // In C#, a catch block is used in conjunction with a try block to handle exceptions. If an exception occurs within the try block,
            // control is transferred to the catch block, where the exception can be handled.
            catch (FormatException)
            {
                // Prints to the screen "Invalid input format".
                Console.WriteLine("Invalid input format.");
            }
            // Prints to the screen "Program execution has continued".
            Console.WriteLine("Program execution has continued.");
        }
    }    
}



