using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace approvalProgramForCarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {

            //Writes "What is your age?"
            Console.WriteLine("What is your age?");
            //Keeps the window from closing
            Console.ReadLine();
            //Convert to int, declares variable
            int yourAge = Convert.ToInt32(Console.ReadLine());          

            //Writes "Have you ever had a DUI?"
            Console.WriteLine("Have you ever had a DUI?");
            //Convert to int, declares variable
            bool anyDUI = Convert.ToBool32(Console.ReadLine());          
            //Writes "How many speeding tickets do you have?"            
            Console.WriteLine("How many speeding tickets do you have?");
            //Convert to int, declares variable
            int anyTickets = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            //Declares variables
            int a = yourAge
            bool b = anyDUI
            int c = anyTickets  
            Console.WriteLine("Are you qualified?");
            Console.WriteLine(a > 15 && b == false && c <= 3 ); 
          }
    }
}
