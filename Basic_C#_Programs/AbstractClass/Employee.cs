using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person
    {   // Overrides the "SayName" method to display the name of the employee.
        public override void SayName()
        {
            //Prints to the screen the first and last names together.
            Console.WriteLine(FirstName + LastName);
        }
    }
}
