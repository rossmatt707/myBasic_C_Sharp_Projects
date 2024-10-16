using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission6Abstract
{
    internal class Employees : Person // Create a class called Employees that inherits from Person
    {
        public override void SayName() // Implement the SayName method
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Output the FirstName and LastName properties
        }
    }
}
