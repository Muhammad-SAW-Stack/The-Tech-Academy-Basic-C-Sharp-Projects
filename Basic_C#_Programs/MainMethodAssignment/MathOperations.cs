using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    class MathOperations
    {
        // The "Calculate" method is a method in a C# class called 'MathOperations'.
        // The method takes in a single parameter of the specified type, performs a math operation on it, and returns the result as an int.
        public int Calculate(int num)
        {
            // Performs a math operation (addition).
            int result = num + 25;
            return result;
        }
        // The "Calculate" method is a method in a C# class called 'MathOperations'.
        // The method takes in a single parameter of the specified type, performs a math operation on it, and returns the result as an int.
        public int Calculate(decimal num)
        {
            // This code performs a different math operation (multiplication).
            int result = (int)(num * 25);
            return result;
        }
        // The "Calculate" method is a method in a C# class called 'MathOperations'.
        // The method takes in a single parameter of the specified type, performs a math operation on it, and returns the result as an int.
        public int Calculate(string num)
        {
            // Converts the string to an integer.
            int intNum = int.Parse(num);
            // This code performs a different math operation (subtraction).
            int result = intNum - 25;
            // Returns results. 
            return result;
        }
    }
}
