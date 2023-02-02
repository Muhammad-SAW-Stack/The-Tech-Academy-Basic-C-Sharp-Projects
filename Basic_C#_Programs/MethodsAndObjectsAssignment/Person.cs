using System;

namespace MethodsAndObjectsAssignment

{
        // Defines the Person class with two properties, FirstName and LastName.
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Id { get; set; }
            // Defines the SayName method that writes the person's name to the screen.
            public void SayName()
            {
                // Prints to the screen "FirstName, LastName, and Id. 
                Console.WriteLine("Name: {0} {1}", FirstName, LastName, Id);
            }
        }
}
