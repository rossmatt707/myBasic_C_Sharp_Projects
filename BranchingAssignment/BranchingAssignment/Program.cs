using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // exception handling
            try
            {
                // Get package weight
                Console.WriteLine("Please enter the package weight:");
                // Convert input to integer
                int weight = Convert.ToInt32(Console.ReadLine());
                // Check if package is too heavy
                if (weight > 50)
                {
                    // Display message and exit if package is too heavy
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    return;
                }

                // Get package dimensions
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                // Check if package is too too big (greater than 50)
                int dimensionsAdded = width + height + length;
                if (dimensionsAdded > 50)
                {
                    // Display message and exit if package is too big
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                    return;
                }
                // Calculate dimensions
                int dimensionsMultiply = width * height * length;
                // Calculate shipping cost
                decimal shippingCost = (dimensionsMultiply * weight) / 100;
                // Display shipping cost to user
                Console.WriteLine("Your estimated total for shipping this package is: $" + shippingCost);
                // Thank user for using service
                Console.WriteLine("Thanks for using our services.");
                Console.ReadLine();

            }
            // Catch any exceptions
            catch (FormatException)
            {
                // Display message if input is not a number
                Console.WriteLine("Please enter a valid number.");
                Console.ReadLine();
            }
        }
    }
}
