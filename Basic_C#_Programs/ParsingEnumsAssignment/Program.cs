using System;
    // "DaysOfWeek" is an enum representing the 7 days of the week.
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
        // Prints to the screen "Enter the current day of the week:".
        Console.WriteLine("Enter the current day of the week:");
            // Saves user's input of current day of the week, as "currentDay".
            string currentDay = Console.ReadLine();
        // The "try" keyword in C# is used to enclose a block of code that might throw an exception.
        // If an exception is thrown within the try block, the code in the corresponding catch block is executed,
        // allowing you to handle the exception and take appropriate action.
        try
        {
                // This code converts the user's input to the enum datatype. "today" represents "currentDay".
                DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), currentDay);
                // Prints to the screen  "Today is 'today'".
                Console.WriteLine("Today is " + today);
            }
        // The "catch" keyword in C# is used in combination with the "try" keyword to handle exceptions that might be thrown within the try block.
        // The catch block takes an argument, which is the type of exception that it will handle.
        // If an exception of the specified type is thrown, the catch block is executed, and the exception is passed to the catch block as an argument.
        // You can use the information in the exception object to handle the exception and take appropriate action.
        catch (Exception)
            {
            // Prints to the screen "Please enter an actual day of the week."
            Console.WriteLine("Please enter an actual day of the week.");
            }
            // Keeps the window from closing. 
            Console.ReadLine();
        }
    }
