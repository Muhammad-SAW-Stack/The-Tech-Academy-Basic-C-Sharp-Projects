using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
            static void Main(string[] args)
            {
                // Instantiate and initialize an Employee object with the firstName Sample, lastName Student, and Id 123.
                Employee employee = new Employee { FirstName = "Sample", LastName = "Student", Id = 123 };

                // Call the SayName method of the superclass (Person)
                employee.SayName();
            }
    }
}

    

