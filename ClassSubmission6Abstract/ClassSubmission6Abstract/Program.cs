﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission6Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees(); // Instantiate an Employee object 
            employee.FirstName = "Sample"; // Set the FirstName property
            employee.LastName = "Student";// Set the LastName property
            employee.SayName(); // Output: Name: Sample Student

            IQuittable quittable = employee; // Instantiate an IQuittable object
            quittable.Quit(); // Output: Employee has quit.
            Console.ReadLine();
        }
    }
}
