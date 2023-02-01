using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints "current Date and Time is : "
            Console.Write("Current Date and Time is : ");
            //"DateTime now" property return the current date and time.
            DateTime now = new DateTime();
            //Prints the current Date and Time.
            Console.WriteLine(now);
            //Keeps window open
            Console.ReadLine();
            //Prints "Please enter a number".
            Console.Write("Please enter a number");
            string yourNum = Console.ReadLine();
            Convert.ToInt32(yourNum);
            DateTime.now = DateTime.AddHours(yourNum);
            Console.ReadLine();
            Console.WriteLine("The time will be " + DateTime.now "in" + yourNum);
            Console.ReadLine();
        }
    }
}
