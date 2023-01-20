using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileStatementDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //declares variable
            int i = 0;
            //while loop is an Entry Controlled Loop in C#. 
            //The test condition is given in the beginning of the 
            //loop and all statements are executed till the given 
            //boolean condition satisfies, when the condition becomes 
            //false, the control will be out from the while loop.
            while (i < 5)
            //Being while statement
            {//Writes variable i
                Console.WriteLine(i);
                Console.ReadLine();

                //increment operator increases number everytime the enter button is hit until it's going from 4 to 5
                i++;
                //Ends while statement
            }

            //The do/while loop is a variant of the while loop. 
            //This loop will execute the code block once, 
            //before checking if the condition is true, 
            //then it will repeat the loop as long as the condition is true.
            do
            {
                // code block to be executed
            }
            //Condition is to be entered in parentheses
            while (i > 6 );
        
            int x = 5;
            int y = 3;
            Console.WriteLine(x > y); // returns True because 5 is greater than 3
        }
    }
}
