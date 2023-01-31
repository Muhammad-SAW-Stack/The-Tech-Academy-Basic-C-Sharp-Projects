using System;

namespace OperatorsAssignment
{
    class Program
    {
        //The Main() method is the first method which gets invoked
        //whenever an application started and it is present in every C# executable file.
        static void Main(string[] args)
        {
            -
            Employee example = new Employee();

            example.FirstName = "Mike";
            example.LastName = "Smith";
            example.ID = 24923;

            Employee example2 = new Employee();
            example2.FirstName = "John";
            example2.LastName = "Doe";
            example2.ID = 39292;

            Console.ReadLine();
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}

