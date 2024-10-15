using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission5Inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Create an object of Employee class
            employee.FirstName = "Sample"; // Assign values to the properties of the FirstName object
            employee.LastName = "Student"; // Assign values to the properties of the LastName object
            employee.Id = 1; // Assign values to the properties of the Id object
            employee.SayName(); // Call the SayName method
            Console.WriteLine("Employee ID: " + employee.Id); // Display the Employee ID
            Console.ReadLine();
        }
    }
}
