using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code code creates a new list of strings.
            List<string> list = new List<string> { "A", "B", "C", "D", "C" };

            // This code is a HashSet to store unique string.
            HashSet<string> uniqueStrings = new HashSet<string>();

            // The foreach loop in C# is used to iterate over a collection of elements, such as arrays or lists. This "foreach" loop is used to evaluate each item in the list.
            foreach (string str in list)
            {
                // If the current string is already in the HashSet, it is a duplicate.
                if (uniqueStrings.Contains(str))
                {
                    // Prints to the screen " C- this item is a duplicate"
                    Console.WriteLine(str + " - this item is a duplicate");
                }
                // If it's not a duplicate, print "this item is unique".
                else
                {
                    // Prints to the screen " A, B, D (respectively)- this item is a unique"
                    Console.WriteLine(str + " - this item is unique");
                    uniqueStrings.Add(str);
                }
            }
            // Keeps the window from closing. 
            Console.ReadLine();
        }
    }
}