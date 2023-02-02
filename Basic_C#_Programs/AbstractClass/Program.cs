using System;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiates an Employee class object with two properties, the first name "Joe" and last name "Smith"
            Employee MyEmployee = new Employee();
            //The first property.
            MyEmployee.FirstName= "Joe";
            //The second property.
            MyEmployee.LastName= "Smith";
            // Calls the "SayName" method on the object
            MyEmployee.SayName();
        }
            
    }
}
