﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_170
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;

        public void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
    }
}
