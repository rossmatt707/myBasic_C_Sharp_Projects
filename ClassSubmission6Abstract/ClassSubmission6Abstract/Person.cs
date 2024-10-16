using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission6Abstract
{
    internal abstract class Person // Create an abstract class called Person
    {
        public string FirstName { get; set; } // Give it the property of FirstName
        public string LastName { get; set; } // Give it the property of LastName

        public abstract void SayName(); // Create an abstract method called SayName
    }
}
