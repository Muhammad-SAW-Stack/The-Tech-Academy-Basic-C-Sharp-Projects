using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Ops_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {   //Writes "Person 1"
            Console.WriteLine("Person 1");
            //Keeps the window from closing
            Console.ReadLine();
            //Writes "14$/hr"
            Console.WriteLine("14$/hr");
            //Keeps the window from closing           
            Console.ReadLine();
            //Writes "40hr/week"            
            Console.WriteLine("40hr/week");
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("17$/hr");
            Console.ReadLine();
            Console.WriteLine("27hr/week");
            Console.ReadLine();
            //Writes "Annual salary of Person 1    
            Console.WriteLine("Annual salary of Person 1:");
            //int is a keyword that is used to declare a variable
            int product = 40 * 14 * 52;
            //Writes the variable 
            Console.WriteLine(product);
            //Keeps window open
            Console.ReadLine();

            //Writes "Annual salary of Person 2
            Console.WriteLine("Annual salary of Person 2:");
            //Declares variable
            int x = 27;
            int y = 17;
            int z = 52;
            //Writes product of variable multiplication
            Console.WriteLine(x * y * z);
            Console.ReadLine();
            //Declares variables
            int Person1 = 29120;
            int Person2 = 23868;
            //The bool type keyword is an alias for the . NET System.
            //Boolean structure type that represents a Boolean value,
            //which can be either true or false.
            bool annualSalary = Person1 > Person2;
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(annualSalary);
            Console.ReadLine();

        }
    }
}
