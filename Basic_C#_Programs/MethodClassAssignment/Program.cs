using System;
// Class named "MathOperation".
class MathOperation
{
    // This code is a void method that takes two integers as parameters.
    // The "public" keyword means it can be accessed anywhere in the program. 
    public void Calculate(int num1, int num2)
    {
        // This code executes a math operation on the first integer.
        int result = num1 + num2;
        // Prints to the screen "The second integer is: 'num2'".
        Console.WriteLine("The second integer is: " + num2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Instantiatings the class called "MathOperation".
        MathOperation mathOp = new MathOperation();
        // Calls the method in the "MathOperation" class, passing in two numbers.
        mathOp.Calculate(10, 20);
        // Calls the method in the "MathOperation" class, specifying the parameters by name.
        mathOp.Calculate(num2: 30, num1: 40);
    }
}