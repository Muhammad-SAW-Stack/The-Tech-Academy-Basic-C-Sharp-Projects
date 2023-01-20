using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            //Writes "Person 1"
            Console.WriteLine("Academy of Learning Career College");
            //Keeps the window from closing
            Console.ReadLine();
            //Writes "Student Daily Report"
            Console.WriteLine("Student Daily Report");
            //Keeps window open
            Console.ReadLine();
            //Writes "What is your name?"
            Console.WriteLine("What is your name?");
            //Defines string, convert to int
            bool yourName = Convert.ToBool32(Console.ReadLine());

            //Keeps window open
            Console.ReadLine();
            //Writes "What course are you on?"
            Console.WriteLine("What course are you on?");
            Console.ReadLine();
            //Defines string, converts it
            bool youCourse = Convert.ToBool32(Console.ReadLine());
            //Writes "What page number?"
            Console.WriteLine("What page number?");
            //Keeps window open
            Console.ReadLine();
            //Defines string, converts it
            int pageNuber = Convert.ToInt32(Console.ReadLine());
            //Writes "WDo you need help with anything?"
            Console.WriteLine("Do you need help with anything?");
            //Defines string, converts it
            bool anyHelp = Convert.ToBool32(Console.ReadLine());
            Console.ReadLine();
            //Writes "Please answer “true” or “false”."
            Console.WriteLine("Please answer “true” or “false”.");
            //Defines string, converts it
            //Defines string, converts it
            bool trueOrFalse = Convert.ToBool32(Console.ReadLine());
            Console.ReadLine();
            // Writes "Were there any positive experiences you’d like to share? Please give specifics."
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            //Defines string, converts it
            bool goodTimes = Convert.ToBool32(Console.ReadLine());
            //Defines string, converts itConsole.ReadLine();
            // Writes "Is there any other feedback you’d like to provide? Please be specific."
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //Defines string, converts it
            bool anyFeedback = Convert.ToBool32(Console.ReadLine());
            Console.ReadLine();
            //Writes "How many hours did you study today ?"
            Console.WriteLine("How many hours did you study today ?");
            //Defines string, converts it
            int todayStudyHours = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            //Writes "Thank you for your answers. An Instructor will respond shortly.Have a great day!"
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly.Have a great day!");











        }
    }
}
