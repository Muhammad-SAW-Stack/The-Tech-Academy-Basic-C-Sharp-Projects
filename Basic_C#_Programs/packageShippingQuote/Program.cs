using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {

            //Writes "Person 1"
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            //Keeps the window from closing
            Console.ReadLine();

            //Writes "14$/hr"
            Console.WriteLine("What is your package weight?");
            string packageWeight = Console.ReadLine();
            //Displays your package weight
            Console.WriteLine("Your package weight is: " + packageWeight);
            //Keeps the window from closing
            Console.ReadLine();
            //Declares variable
            int a = packageWeight;
            int b = 50;
            if {
            Console.WriteLine(a > b);
            Console.WriteLine(“Package too heavy to be shipped via Package Express. Have a good day.”);
            }
            //Asks for package width
            Console.WriteLine("What is your package width?");
            Console.ReadLine();
            //Asks for package hieght
            Console.WriteLine("What is your package height?");
            Console.ReadLine();
            //Asks for package length
            Console.WriteLine("What is your package length?");
            Console.ReadLine();
            string packageDimensions = Console.ReadLine();
            int x = packageWidth;
            int y = PackageHeight;
            int z = packageLength;
            Console.WriteLine(x * y * z);
            //Shows width multiplied by height multiplied by length
            Console.WriteLine("Your package weight is: " + x * y * z);
            //Shows the quote, which is package dimensions multiplied by package weight divided by 100
            Console.WriteLine("Your quote is: " + packageDimensions * a / 100);
        }
    }
}


            
