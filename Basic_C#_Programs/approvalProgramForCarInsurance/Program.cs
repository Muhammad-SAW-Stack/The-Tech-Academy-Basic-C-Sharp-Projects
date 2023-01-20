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
            string yourAge = Console.ReadLine();
            //Writes "Have you ever had a DUI?"
            Console.WriteLine("Have you ever had a DUI?");
            string anyDUI = Console.ReadLine();           
            //Writes "How many speeding tickets do you have?"            
            Console.WriteLine("How many speeding tickets do you have?");
            string anyTickets = Console.ReadLine();
            Console.ReadLine();
            if (anyDUI >= 1);
            {
                Console.WriteLine("You do not qualify");
            }
            if (yourAge < 15);
            {
                Console.WriteLine("You do not qualify");
            }
            if (anyTickets > 3)
            {
                Console.WriteLine("You do not qualify");
            }
            
            
          
        }
    }
}
