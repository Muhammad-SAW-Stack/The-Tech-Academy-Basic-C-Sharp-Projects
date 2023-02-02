using System;
            using System.Collections.Generic;
            using System.Linq;

namespace ConsoleApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creates a list of 10 employees with a first and last name, as well as a unique Id number.
                List<Employee> employees = new List<Employee>()
            {
                new Employee{ Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee{ Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee{ Id = 3, FirstName = "Joe", LastName = "Smith" },
                new Employee{ Id = 4, FirstName = "Jim", LastName = "Brown" },
                new Employee{ Id = 5, FirstName = "Amy", LastName = "Johnson" },
                new Employee{ Id = 6, FirstName = "Joe", LastName = "Johnson" },
                new Employee{ Id = 7, FirstName = "Michael", LastName = "Williams" },
                new Employee{ Id = 8, FirstName = "Sarah", LastName = "Davis" },
                new Employee{ Id = 9, FirstName = "David", LastName = "Miller" },
                new Employee{ Id = 10, FirstName = "Jessica", LastName = "Wilson" }
            };
                // This code uses a foreach loop to create a list of all employees with the first name “Joe”.
                List<Employee> joeList = new List<Employee>();
                foreach (Employee employee in employees)
                {
                    if (employee.FirstName == "Joe")
                    {
                        joeList.Add(employee);
                    }
                }
                // This code displays the list of employees with the first name “Joe”.
                Console.WriteLine("List of employees with the first name Joe (using foreach loop):");
                foreach (Employee employee in joeList)
                {
                    // Prints to the screen "Id: 3, First Name: Joe, Last Name: Smith".
                    //                      "Id: 6, First Name: Joe, Last Name: Johnson".
                    Console.WriteLine("Id: {0}, First Name: {1}, Last Name: {2}", employee.Id, employee.FirstName, employee.LastName);
                }
                //This code uses a lambda expression to create a list of all employees with the first name “Joe”.
                List<Employee> joeList2 = employees.Where(e => e.FirstName == "Joe").ToList();
                // This code displays the list of employees with the first name “Joe”.
                Console.WriteLine("\nList of employees with the first name Joe (using lambda expression):");
                foreach (Employee employee in joeList2)
                {
                // Prints to the screen "Id: 3, First Name: Joe, Last Name: Smith".
                //                      "Id: 6, First Name: Joe, Last Name: Johnson".
                Console.WriteLine("Id: {0}, First Name: {1}, Last Name: {2}", employee.Id, employee.FirstName, employee.LastName);
                }
                //This code uses a lambda expression to create a list of all employees with an Id number greater than 5.
                List<Employee> employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();
                //This code displays the list of employees with an Id number greater than 5.
                Console.WriteLine("\nList of employees with an Id number greater than 5 (using lambda expression):");
                foreach (Employee employee in employeesWithIdGreaterThan5)
                {
                // Prints to the screen "Id: 6, First Name: Joe, Last Name: Johnson.
                //                      "Id: 7, First Name: Michael, Last Name: Williams.
                //                      "Id: 8, First Name: Sarah, Last Name: Davis.
                //                      "Id: 9, First Name: David, Last Name: Miller.
                //                      "Id: 10, First Name: Jessica, Last Name: Wilson.
                    Console.WriteLine("Id: {0}, First Name: {1}, Last Name: {2}", employee.Id, employee.FirstName, employee.LastName);
                }
        }
    }
}
