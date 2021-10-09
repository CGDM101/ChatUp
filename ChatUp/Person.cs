using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public bool IsBlocked { get; set; }

        public Person(string firstName, string lastName, string alias) // Metod som körs vid varje instantiering av Person.
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Alias = alias;
        }

        public Person() // default
        {
        }
    }
}
