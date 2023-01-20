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

            //Writes "Welcome to Package Express. Please follow the instructions below"
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            //Keeps the window from closing
            Console.ReadLine();

            //Writes "What is your package weight?"
            Console.WriteLine("What is your package weight?");
            Defines string
            string packageWeight = Console.ReadLine();
            //Convert the string packageWeight to int
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            //Displays your package weight
            Console.WriteLine("Your package weight is: " + packageWeight);
            //Keeps the window from closing
            Console.ReadLine();
            //Declares variable
            //Defines int variables
            int a = packageWeight;
            int b = 50;
            if {
            Console.WriteLine(a > b);
            
            Console.WriteLine(“Package too heavy to be shipped via Package Express. Have a good day.”);
            }
            //Asks for package width
            Console.WriteLine("What is your package width?");
            Console.ReadLine();
            //Defines string
            //Convert string to int
            int packageWidth2 = Convert.ToInt32(Console.ReadLine());
            //Asks for package hieght
            Console.WriteLine("What is your package height?");
            Console.ReadLine();
            //Defines string 
            // //Converts string to int
            int packageHeight2 = Convert.ToInt32(Console.ReadLine());
            //Asks for package length
            Console.WriteLine("What is your package length?");
            //Defines string 
            //Converts string to int
            int packageLength2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            string packageDimensions = Console.ReadLine();
            Convert.ToInt32(packageDimensions);
            int x = packageWidth2;
            int y = PackageHeight2;
            int z = packageLength2;
            Console.WriteLine(x * y * z);
            //Shows width multiplied by height multiplied by length
            Console.WriteLine("Your package weight is: " + x * y * z);
            //Shows the quote, which is package dimensions multiplied by package weight divided by 100
            Console.WriteLine("Your quote is: " + packageDimensions * a / 100);
        }
    }
}


            
