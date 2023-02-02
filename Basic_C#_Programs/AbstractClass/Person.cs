using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    //Abstract class consisting of two properties, a FirstName, and LastName.
    abstract public class Person
    {
        //The FirstName property.
        public string FirstName { get; set; }
        //The LastName property.
        public string LastName { get; set; }
        //Method which displays the name of the person.
        public abstract void SayName();
    }
}
