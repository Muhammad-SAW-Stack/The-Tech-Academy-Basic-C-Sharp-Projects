using MathOperations;
using System;

namespace Calling_Methods
{

    class Program 
    {

        static void Main(string[] args)
        {
            // Instantiates the Operations class
            Operations mathOps = new Operations();
            // Prints to the screen "Enter a number:".
            Console.WriteLine("Enter a number: ");
            // Saves and converts the users input.
            int userInput = int.Parse(Console.ReadLine());
            // Calls the Addition method, passes the user input as an argument, and stores the result in a variable.
            int result1 = mathOps.Addition(userInput);
            // Calls the Subtraction method, passes the user input as an argument, and stores the result in a variable.
            int result2 = mathOps.Subtraction(userInput);
            // Calls the Multiplication method, passes the user input as an argument, and stores the result in a variable.
            int result3 = mathOps.Multiplication(userInput);
            // Prints to the screen "After addition, the result is:" the with the added result displayed.
            Console.WriteLine("After addition, the result is: " + result1);
            // Prints to the screen "After subtraction, the result is:" the with the subtracted result displayed.
            Console.WriteLine("After subtraction, the result is: " + result2);
            // Prints to the screen "After multiplication, the result is:" the with the multiplied result displayed.
            Console.WriteLine("After multiplication, the result is: " + result3);
            // This causes the window to stay open until a key is pressed.
            Console.ReadKey();
        }
    }
}       

                
