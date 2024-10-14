using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CallingMethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Defines a boolean variable to control the loop
            bool finished = false;
            // Loop to keep the program running until the user enters a number
            while (finished == false)
            {
                // Try block to catch exceptions
                try
                {

                    // Instantiates a new MathOp object
                    MathOp mathOp = new MathOp();

                    // Prompts the user to enter a number
                    Console.WriteLine("Enter a number and we'll add, subtract and multiply five: ");
                    string input = Console.ReadLine();
                    // Converts the user input to an integer
                    int num = int.Parse(input);
                    // Calls the AddFive method from the MathOp class
                    int result = mathOp.AddFive(num);
                    Console.WriteLine("Adding five to your number: " + result);
                    Thread.Sleep(1000);
                    // Calls the SubtractFive method from the MathOp class
                    int result2 = mathOp.SubtractFive(num);
                    Console.WriteLine("Subtracting five from your number: " + result2);
                    Thread.Sleep(1000);
                    // Calls the MultiplyFive method from the MathOp class
                    int result3 = mathOp.MultiplyFive(num);
                    Console.WriteLine("Multiplying your number by five: " + result3);
                    Thread.Sleep(1000);
                    // Writes message to consol for end of program
                    Console.WriteLine("\nThanks for using our comprehensive math service! Press any key to exit.");
                    // Sets the boolean variable to true to end the loop
                    finished = true;
                }
                // Catch block to handle exceptions
                catch (Exception ex)
                {
                    // Writes the exception message to the console if an exception is thrown
                    Console.WriteLine("Please enter a number:");
                    
                }
            }


        }
    }
}
