using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        public void Main()
        {
            //Crates array of strings named car.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Prints "Select an index of the array"
            Console.WriteLine("Select an index of the array");
            //Keeps window open.
            Console.ReadLine();
            // Outputs Volvo
            Console.WriteLine(cars[0]);
            //Keeps window open.
            Console.ReadLine();
            //Crates array of integars named myNum.
            int[] myNum = { 10, 20, 30, 40 };
            //Prints "Select an index of the array"
            Console.WriteLine("Select an index of the array");
            //Keeps window open. 
            Console.ReadLine();
            //Prints 30
            Console.WriteLine(myNum[2]);
            Console.ReadLine();

            // Create a list of strings  
            List<string> nations = new List<string>(new string[] { "Turkey", "Italy", "Japan", "Canada", "Syria" });
            //Prints "Select an index of the array"
            Console.WriteLine("Select an index of the array");
            //Keeps window open.
            Console.WriteLine(nations[0]);



          
           
        }
    }
}









          