using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints to the screen the current date and time.
            Console.WriteLine("Current Date and Time: " + DateTime.Now);

            // Prints to the screen "Enter a number".
            Console.WriteLine("Enter a number:");
            int hours = int.Parse(Console.ReadLine());

            // Calculates and displays the time after X hours
            DateTime futureTime = DateTime.Now.AddHours(hours);
            // Prints to the screen "Time after 'X hours' 'futureTime'.
            Console.WriteLine("Time after " + hours + " hours: " + futureTime);
        }
    }
}
