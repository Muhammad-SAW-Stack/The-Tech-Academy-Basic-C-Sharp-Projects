using System;

    class MathOperations
    {
        class Subtract
        {
        public void Main(string[] args)
        {

            // Subtract the first number by the second number.
            decimal d1 = 1.2m;
            decimal d2 = 2.3m;
            decimal d3 = 4.4m;
            decimal d4 = 6.5m;

            // subtract decimal values
            decimal n1 = decimal.Subtract(d1, d2);
            decimal n2 = decimal.Subtract(d3, d4);

            // print results
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
                
    }
        
 }
 


