using System;

namespace Console_App_String_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number you wish to divide the numbers in the list by.");
            string divideBy = Console.ReadLine();
            Convert.ToInt32(divideBy);
            int[] numberArray = { 48, 72, 14, 88 };
            foreach (var item in numberArray)
            {
                var result = item / divideBy;
            }

            Console.ReadLine();
        }
    }
}
