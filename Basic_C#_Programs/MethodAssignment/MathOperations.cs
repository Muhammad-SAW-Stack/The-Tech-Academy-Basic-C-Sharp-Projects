using System;

    // Class definition 
    class MathOperation
    {
            // Method that takes two integers as parameters, with one of them optional
            public int Calculate(int num1, int num2 = 0)
            {
                // Math operation (in this case, addition)
                int result = num1 + num2;
                return result;
            }
       
    }
