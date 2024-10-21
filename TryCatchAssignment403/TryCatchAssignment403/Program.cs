using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: "); // Prompt user to enter their age
            try // Try block to catch any exceptions
            {
                int age = Convert.ToInt32(Console.ReadLine()); // Convert user input to integer
                if (age <= 0) // If age is less than or equal to 0
                {
                    throw new ArgumentException(); // Throw an exception
                }
                int yearOfBirth = DateTime.Now.Year - age; // Calculate the year of birth
                Console.WriteLine("You were born in " + yearOfBirth); // Display the year of birth
            }
            catch (ArgumentException) // Catch the exception
            {
                Console.WriteLine("Please enter a valid age."); // Display an specific error message
            }
            catch (Exception) // Catch any other exceptions
            {
                Console.WriteLine("An error occurred. Please try again."); // Display a generic error message
            }
        }
    }
}
