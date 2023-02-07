using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates the class.
            MathOperations mathOperations = new MathOperations();

            // Prints to the screen ""Enter a number: ".
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // This code calls the method to divide the number by 2.
            int result = mathOperations.DivideByTwo(number);
            Console.WriteLine("The result after dividing the number by 2 is: " + result);

            // This code calls the method with output parameters.
            int result2, remainder;
            mathOperations.DivideByTwoWithOutputParameters(number, out result2, out remainder);
            Console.WriteLine("The result after dividing the number by 2 with output parameters is: " + result2);
            Console.WriteLine("The remainder after dividing the number by 2 with output parameters is: " + remainder);

            // This code overloads the method with a double type number.
            double decimalNumber = 5.5;
            double result3 = mathOperations.DivideByTwo(decimalNumber);
            Console.WriteLine("The result after dividing the decimal number by 2 is: " + result3);
        }
    }

    // This code declares the class to be static.
    static class MathOperations
    {
        // This code is a method that divides an integer by 2 and returns the result.
        public int DivideByTwo(int num)
        {
            return num / 2;
        }

        // This code is a method that divides a double by 2 and returns the result.
        public double DivideByTwo(double num)
        {
            return num / 2;
        }

        // This code is a method that divides an integer by 2 and returns the result and the remainder using output parameters.
        public void DivideByTwoWithOutputParameters(int num, out int result, out int remainder)
        {
            result = num / 2;
            remainder = num % 2;
        }
    }
}