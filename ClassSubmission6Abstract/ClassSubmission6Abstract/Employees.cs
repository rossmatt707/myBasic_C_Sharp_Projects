using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission6Abstract
{
    internal class Employees : Person, IQuittable // Create a class called Employees that inherits from Person and implements IQuittable
    {
        public override void SayName() // Implement the SayName method
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Output the FirstName and LastName properties
        }
        void IQuittable.Quit() // Implement the Quit method
        {
            Console.WriteLine("Employee has quit."); // Output that the employee has quit
        }
    }
}
