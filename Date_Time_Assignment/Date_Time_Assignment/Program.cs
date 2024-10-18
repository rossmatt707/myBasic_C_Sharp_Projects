using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_Time_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console.
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time is: " + now);
            

            Console.WriteLine("Enter a number: "); // Ask the user for a number.
            int num = Convert.ToInt32(Console.ReadLine());// Convert the input to an integer and store it in a variable.
            Console.WriteLine($"In {num} hours, it will be {now.AddHours(num)}"); // Add the number to the current time and print the result to the console.
            Console.ReadLine(); // Keep the console open.
        }
    }
}
