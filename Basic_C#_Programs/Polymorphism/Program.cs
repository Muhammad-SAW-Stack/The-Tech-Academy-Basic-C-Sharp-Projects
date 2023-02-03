using System;
        // Declares an interface named "IQuittable".
        interface IQuittable
        {
            // Declares a void method "Quit".
            void Quit();
        }
        // Declares the class "Employee", which inherits from the "IQuittable" interface.
        class Employee : IQuittable
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        // Implements the "Quit" method from the "IQuittable" interface. The "public" keyword means that it can be accessed from anywhere within the program.
        public void Quit()
            {
                // Prints to the screen "Employee has quit the job."
                Console.WriteLine("Employee has quit the job.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // This code creates an object of the "Employee" class with two properties, the 'FirstName' "John", and 'LastName' "Smith".
                Employee employee = new Employee { FirstName = "John", LastName = "Smith" };
                // This code creates an object of the "IQuittable" interface and assigns it to the "employee" object.
                IQuittable quittableEmployee = employee;
                // This code calls the "Quit" method on the "quittableEmployee" object.
                quittableEmployee.Quit();
                // Keeps the window from closing.
                Console.ReadLine();
            }
        }
    

