using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Math class
            Math math = new Math();

            // Define a boolean variable to control the loop
            bool loop1 = true;
            // Start of loop1
            while (loop1 == true)
            {
                // Try block to catch exceptions
                try
                {
                    // Prompt the user to enter a number
                    Console.WriteLine("Enter a number: ");
                    // Convert the user input to an integer
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    // Call the Operation method with the integer parameter
                    int result = math.Operation(num1);
                    // Display the result
                    Console.WriteLine("The number you entered plus 5 is: " + result);
                }
                // Catch block to handle exceptions
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Prompt the user to try again
                    Console.WriteLine("Try again ? (y/n)");
                    string answer = Console.ReadLine();
                    // If the user enters "n", exit the loop
                    if (answer == "n")
                    {
                        Console.WriteLine("Bye!");
                        loop1 = false;
                    }
                }
            }

            bool loop2 = true;
            while (loop2 == true)
            {
                try
                {
                    // Prompt the user to enter a decimal number
                    Console.WriteLine("Enter a decimal number: ");
                    // Convert the user input to a double
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    // Call the Operation method with the double parameter
                    double result = math.Operation(num1);
                    Console.WriteLine("The number you entered minus 5 is: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Try again? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        Console.WriteLine("Bye!");
                        loop2 = false;
                    }
                }

                bool loop3 = true;
                while (loop3 == true)
                {
                    try
                    {
                        // Prompt the user to enter a number
                        Console.WriteLine("Enter a number: ");
                        // Read the user input as a string
                        string num1 = Console.ReadLine();
                        // Call the Operation method with the string parameter
                        int result = math.Operation(num1);
                        Console.WriteLine("The number you entered multiplied by 5 is: " + result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Try again? (y/n)");
                        string answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            loop3 = false;
                        }
                    }
                }

                Console.WriteLine("\nFarewell.. Thanks for using our fine software!");
                Console.ReadLine();
            }
        }
    }
}
