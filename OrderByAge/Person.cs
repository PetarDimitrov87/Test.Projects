using System;
using System.Collections.Generic;
using System.Text;

namespace OrderByAge
{
    public class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
