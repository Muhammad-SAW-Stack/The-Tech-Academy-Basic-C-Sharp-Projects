using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{   //Creates class called 'Employee'. ":" tells 'Employee' class
    //to inherit from 'Person' class//
    class Employee : Person
    {
        // The following is an Auto-Implemented Property.
        // It's basically a shorthand way of creating properties for a class in C#,
        // without having to define private variables
        // for them. They are normally used when no extra logic is required
        // when getting or setting the value of a variable.
        public int ID { get; set; }
        //"Operator" Overloading C# lets you overload operators to work with operands
        // that are custom classes or structs using operators.
        public static bool operator ==(Employee employee, Employee employee2)
        {
            //The if Statement. Use the if statement to specify a block of C# code to be executed
            //if a condition is True
            if (employee.ID == employee2.ID)
                return true;
            //If not true
            else
                //Return false
                return false;
        }
        //"Operator" Overloading C# lets you overload operators to work with operands
        // that are custom classes or structs using operators.
        public static bool operator !=(Employee employee, Employee employee2)
        {
            //Return 'employee ID' does not equal 'employee ID'. 
            return employee.ID != employee2.ID;
        }
        //An override method provides a new implementation of the method inherited from a base class.
        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.ID.Equals(emp.ID);
        }
}
