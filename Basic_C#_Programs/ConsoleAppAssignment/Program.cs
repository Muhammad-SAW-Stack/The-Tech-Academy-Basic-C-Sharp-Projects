using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code creates a one-dimensional array of strings.
            string[] arr = new string[] { "One", "Two", "Three" };
            // Prints to the screen "Enter text to add to each string in the array:".
            Console.WriteLine("Enter text to add to each string in the array:");
            // Saves user's input as "userText.
            string userText = Console.ReadLine();
            // This code is a "for loop" that iterates through each string in the array and adds the user's text input to the end of each string.
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += userText;
            }
            // This code is a second loop that prints off each string in the array one at a time.
            Console.WriteLine("Array elements after adding user's text:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // Fix the infinite loop.
            int count = 0;
            // A while loop in C# is a control flow statement that allows you to repeat a block of code as long as a given condition is true. 
            while (count < arr.Length)
            {
                Console.WriteLine("Array element: " + arr[count]);
                count++;
            }
            // Infinite loop fixed by using a counter variable to control the number of iterations.
            // This code is a "for loop", where the comparison used to determine whether to continue iterating the loop is a "<" (less than) operator.
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // A "for loop" where the comparison used to determine whether to continue iterating the loop is a "<=" (less than or equal to) operator.
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // This creates a list of strings, where each item in the list is a unique string.
            List<string> list = new List<string>() { "Apple", "Banana", "Cherry" };
            // Prints to the screen "Enter text to search in the list:".
            Console.WriteLine("Enter text to search in the list:");
            // Saves user's input as "searchText".
            string searchText = Console.ReadLine();
            // int index = -1
            int index = -1;
            // A "for loop" that iterates through the list, and displays the index of the list item that contains matching text.
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(searchText))
                {
                    index = i;
                    break;
                }
            }
            // This checks if the user's input is not in the list.
            if (index == -1)
            {
                // If not it's in the list, prints "The input text is not in the list."
                Console.WriteLine("The input text is not in the list.");
            }
            else
            {
                // If it is in the list, prints "The input text is at index 'index'".
                Console.WriteLine("The input text is at index " + index);
            }
            // This creates a list of strings that has at least two identical strings.
            List<string> listWithDuplicates = new List<string>() { "Apple", "Banana", "Cherry", "Banana" };
            // Prints to the screen "Enter text to search for in the list with duplicates:".
            Console.WriteLine("Enter text to search for in the list with duplicates:");
            string searchTextDupl = Console.ReadLine();
            bool matchFound = false;
            // This creates a "for loop" that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            for (int i = 0; i < listWithDuplicates.Count; i++)
            {
                // "if" "listWithDuplicates" is equal to "searchTextDup1".
                if (listWithDuplicates[i] == searchTextDupl)
                {
                    // Then prints to the screen "Match found at index: " + i".
                    Console.WriteLine("Match found at index: " + i);
                    matchFound = true;
                }
            }
            // This checks if the user's input is on the list.
            if (!matchFound)
            {
                // If not match is found, prints to the screen "Input not found in the list."
                Console.WriteLine("Input not found in the list.");
            }
        }
    }
}