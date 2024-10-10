using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare two numbers
            double num1 = 99;
            double num2 = 2;

            // Perform addition
            double additionResult = num1 + num2;
            Console.WriteLine($"Addition of {num1} and {num2} is: {additionResult}");

            // Perform subtraction
            double subtractionResult = num1 - num2;
            Console.WriteLine($"Subtraction of {num1} and {num2} is: {subtractionResult}");

            // Perform multiplication
            double multiplicationResult = num1 * num2;
            Console.WriteLine($"Multiplication of {num1} and {num2} is: {multiplicationResult}");

            // Perform division
            if (num2 != 0) // Check to avoid division by zero
            {
                double divisionResult = num1 / num2;
                Console.WriteLine($"Division of {num1} by {num2} is: {divisionResult}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // Keep the console open
            Console.ReadLine();
        }
    }
}