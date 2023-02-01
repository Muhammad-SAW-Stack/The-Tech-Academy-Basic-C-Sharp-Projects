using System;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee MyEmployee = new Employee();
            MyEmployee.FirstName= "Joe";
            MyEmployee.LastName= "Smith";

            MyEmployee.SayName();
        }
            
    }
}
