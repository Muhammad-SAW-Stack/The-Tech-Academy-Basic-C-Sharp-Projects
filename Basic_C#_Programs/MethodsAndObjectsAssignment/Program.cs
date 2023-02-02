using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
            static void Main(string[] args)
            {
                // Instantiates and initializes an Employee object with the firstName Sample, lastName Student, and Id 123.
                Employee employee = new Employee { FirstName = "Sample", LastName = "Student", Id = 123 };

                // Calls the "SayName" method of the parent class/base class/superclass (Person).
                employee.SayName();
            }
    }
}

    

