using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission5Inherit
{
    internal class Person // Create a class called Person
    {
        public string FirstName { get; set; } // Create a property called FirstName
        public string LastName { get; set; } // Create a property called LastName

        public void SayName() // Create a method called SayName
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Display the properties FirstName and LastName
        }

    }
}
