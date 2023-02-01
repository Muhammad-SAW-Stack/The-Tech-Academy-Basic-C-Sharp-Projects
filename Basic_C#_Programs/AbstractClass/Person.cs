﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void SayName();
    }
}
