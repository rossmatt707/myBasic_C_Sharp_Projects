using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment398
{
    internal class Person
    {
        // These are the properties of the Person class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PoliticalParty { get; set; }
        public int Age { get; set; }

        //default constructor that chains to overloaded constructor
        public Person() : this("John", "Doe", "Independent", 35)
        {
        }

        // This is the overloaded constructor
        public Person(string firstName, string lastName, string politicalParty, int age)
        {
            FirstName = firstName; // First name is set to the value passed in
            LastName = lastName; // Last name is set to the value passed in
            PoliticalParty = politicalParty; // Political party is set to the value passed in
            Age = age; // Age is set to the value passed in
        }
    }
}
