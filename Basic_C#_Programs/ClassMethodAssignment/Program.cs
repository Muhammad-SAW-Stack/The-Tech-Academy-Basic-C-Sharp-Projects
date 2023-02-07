using System;

namespace ConsoleApp1
{
    // Class for performing operations
    static class Operations
    {
        // Method to divide number by 2 and output result
        public static void DivideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine(result);
        }

        // Method with output parameters to divide number by 2 and return result
        public static void DivideByTwo(int num, out int result)
        {
            result = num / 2;
        }

        // Overloaded method to divide number by custom value and return result
        public static int DivideByTwo(int num, int divisor)
        {
            return num / divisor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Prints to the screen "Enter a number:"
            Console.WriteLine("Enter a number:");
            // Saves user input as "userNum".
            int userNum = int.Parse(Console.ReadLine());
            // Prints to the screen "Divided by 2:"
            Console.WriteLine("Divided by 2: ");
            // This code calls the method to divide the user's input by 2
            Operations.DivideByTwo(userNum);
            // integer result.
            int result;
            // This code calls the method with output parameters to divide the user's input by 2. 
            Operations.DivideByTwo(userNum, out result);
            // Prints to the screen "Divided by 2: 'result'".
            Console.WriteLine("Divided by 2: " + result);
            // Prints to the screen "Enter a divisor:".
            Console.WriteLine("Enter divisor: ");
            // Saves user's input as "divisor".
            int divisor = int.Parse(Console.ReadLine());
            // This code calls overloaded method to divide the user's input by the custom value ('divisor').
            int customResult = Operations.DivideByTwo(userNum, divisor);
            // Prints to the screen "Result: 'customResult'".
            Console.WriteLine("Result: " + customResult);
        }
    }
}