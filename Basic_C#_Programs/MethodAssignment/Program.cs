using System;

namespace MethodAssignment
{
    class Program
    {
            static void Main(string[] args)
            {
                // Instantiates the class "MathOperation".
                MathOperation math = new MathOperation();

                // Prints to the screen "Enter first number:".
                Console.WriteLine("Enter first number:");
                // Saves and converts the first number the user imputed as "firstNum".
                int firstNum = int.Parse(Console.ReadLine());

                // Prints to the screen "Enter second number (optional):".
                Console.WriteLine("Enter second number (optional):");
                // Saves and converts the second number the user imputed as "secondNumImput".
                string secondNumInput = Console.ReadLine();
                // int secondNum.
                int secondNum;
                // int result.
                int result;
            // With the "if" statement, the code inside the parenthesis is the condition to be met.
            // In C#, the "if" statement is a conditional statement,
            // that allows you to execute a block of code only if a specified condition is true.
            if (string.IsNullOrEmpty(secondNumInput))
                {
                    // The code inside of the "if" statement's curly brackets is the code to be executed if the condition is true.
                    // Calls the method with one number if second number is not entered.
                    result = math.Calculate(firstNum);
                }
                else
                {
                    // Call method with two numbers if second number is entered
                    secondNum = int.Parse(secondNumInput);
                    result = math.Calculate(firstNum, secondNum);
                }

                // Display result
                Console.WriteLine("Result: " + result);
                Console.ReadLine();
            }
    }
}


