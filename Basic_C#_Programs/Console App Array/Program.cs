﻿using System;
using System.Collections.Generic;

namespace Console_App_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a one-dimensional array of strings with 5 elements.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Prints "Select an index of the array (between 0-3)".
            Console.WriteLine("Select an index of the array (between 0-3)");
            int stringIndex = int.Parse(Console.ReadLine());
            // Display the string at the index the user selected.
            if (stringIndex >= 0 && stringIndex <= 4)
            {
                // Prints to the screen "The string at index 'stringIndex' is 'cars[stringIndex]'.
                Console.WriteLine("The string at index " + stringIndex + " is: " + cars[stringIndex]);
            }
            // Prints to the screen "Index does not exist in the array".
            else
            {
                // Prints to the screen "Index 'stringIndex' does not exist in the string array".
                Console.WriteLine("Index " + stringIndex + " does not exist in the string array.");
            }
            // Declares a one-dimensional array of integers called "intArray" with 5 elements.
            int[] intArray = { 1, 2, 3, 4, 5 };
            // Asks the user to select an index of the array.
            Console.WriteLine("Please select an index of the integer array (between 0-3)");
            int intIndex = int.Parse(Console.ReadLine());
            // Displays the integer at the selected index.
            if (intIndex >= 0 && intIndex <= 4)
            {
                Console.WriteLine("The integer at index " + intIndex + " is: " + intArray[intIndex]);
            }
            // Displays an error message if the index selected is out of range.
            else
            {
                // Prints to the screen "Index 'intIndex' does not exist in the integer array".
                Console.WriteLine("Index " + intIndex + " does not exist in the integer array.");
            }
            // Declares a list of strings with 5 elements.
            var stringList = new List<string> { "Turkey", "Italy", "Japan", "Germany" };
            // Asks the user to select an index in the list.
            Console.WriteLine("Please select an index of the string list (between 0-3)");
            // Saves and converts "listIndex".
            int listIndex = int.Parse(Console.ReadLine());
            // Displays the string at the selected index.
            if (listIndex >= 0 && listIndex <= 4)
            {
                // // Prints to the screen "The string at index 'listIndex' is 'stringList[listIndex]'.
                Console.WriteLine("The string at index " + listIndex + " is: " + stringList[listIndex]);
            }
            // Displays an error message if the index is out of range.
            else
            {
            // Prints to the screen "Index 'listIndex' does not exist in the string list".
            Console.WriteLine("Index " + listIndex + " does not exist in the string list.");
            }
            // Keeps the window open. 
            Console.ReadLine();
        }
    }
}

