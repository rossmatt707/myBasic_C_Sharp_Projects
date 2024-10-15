using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Math class
            Math math = new Math();
            // Prompt the user to enter two numbers to be added together
            Console.WriteLine("You need to enter two numbers to be added together. The second number is optional.");

           
            
            int num1 = 0;
            // Loop to validate the first number
            bool validFirstNumber = false;
            while (!validFirstNumber)
            {
                // Prompt the user to enter the first number
                Console.WriteLine("Enter the first number: ");
                try
                {
                    // Convert the user input to an integer
                    num1 = Convert.ToInt32(Console.ReadLine());
                    // Set the boolean variable to true to exit the loop
                    validFirstNumber = true;
                }
                // Catch block to handle exceptions
                catch (Exception ex)
                {
                    // General error message that restarts loop.
                    Console.WriteLine("Invalid input. Please enter a valid integer for the first number.");
                }
            }

            // Prompt the user to enter the second number
            Console.WriteLine("Enter the second number (optional): ");
            string input = Console.ReadLine();
            int result;

            // If the user does not enter a second number...
            if (string.IsNullOrWhiteSpace(input))
            {
                // Call the TwoInt method with one parameter
                result = math.TwoInt(num1);
            }
            else
            {
                // Loop to validate the second number
                int num2 = 0;
                bool validSecondNumber = false;
                // Start of loop
                while (!validSecondNumber)
                {
                    try
                    {
                        // Convert the user input to an integer
                        num2 = Convert.ToInt32(input);
                        // Set the boolean variable to true to exit the loop
                        validSecondNumber = true;
                    }
                    // Catch block to handle exceptions
                    catch (Exception ex)
                    {
                        // Error message that restarts loop.
                        Console.WriteLine("Invalid input. Please enter a valid integer for the second number or press Enter to skip:");
                        // Read the user input
                        input = Console.ReadLine();
                        // Check if the user pressed Enter
                        if (string.IsNullOrWhiteSpace(input))
                        {
                            // Call the TwoInt method with one parameter
                            result = math.TwoInt(num1);
                            // Display the result
                            Console.WriteLine("The result is: " + result);
                            Console.ReadLine();
                            return;
                        }
                    }
                }
                // Call the TwoInt method with two parameters
                result = math.TwoInt(num1, num2);
            }
            // Display the result
            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
        }
    }
}



// For referance

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MainMethodAssignment
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Instantiate the Math class
//            Math math = new Math();

//            // Define a boolean variable to control the loop
//            bool loop1 = true;
//            // Start of loop1
//            while (loop1 == true)
//            {
//                // Try block to catch exceptions
//                try
//                {
//                    // Prompt the user to enter a number
//                    Console.WriteLine("Enter a number: ");
//                    // Convert the user input to an integer
//                    int num1 = Convert.ToInt32(Console.ReadLine());
//                    // Call the Operation method with the integer parameter
//                    int result = math.Operation(num1);
//                    // Display the result
//                    Console.WriteLine("The number you entered plus 5 is: " + result);
//                }
//                // Catch block to handle exceptions
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//                finally
//                {
//                    // Prompt the user to try again
//                    Console.WriteLine("Try again ? (y/n)");
//                    string answer = Console.ReadLine();
//                    // If the user enters "n", exit the loop
//                    if (answer == "n")
//                    {
//                        Console.WriteLine("Bye!");
//                        loop1 = false;
//                    }
//                }
//            }

//            bool loop2 = true;
//            while (loop2 == true)
//            {
//                try
//                {
//                    // Prompt the user to enter a decimal number
//                    Console.WriteLine("Enter a decimal number: ");
//                    // Convert the user input to a double
//                    double num1 = Convert.ToDouble(Console.ReadLine());
//                    // Call the Operation method with the double parameter
//                    double result = math.Operation(num1);
//                    Console.WriteLine("The number you entered minus 5 is: " + result);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//                finally
//                {
//                    Console.WriteLine("Try again? (y/n)");
//                    string answer = Console.ReadLine();
//                    if (answer == "n")
//                    {
//                        Console.WriteLine("Bye!");
//                        loop2 = false;
//                    }
//                }

//                bool loop3 = true;
//                while (loop3 == true)
//                {
//                    try
//                    {
//                        // Prompt the user to enter a number
//                        Console.WriteLine("Enter a number: ");
//                        // Read the user input as a string
//                        string num1 = Console.ReadLine();
//                        // Call the Operation method with the string parameter
//                        int result = math.Operation(num1);
//                        Console.WriteLine("The number you entered multiplied by 5 is: " + result);
//                    }
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine(ex.Message);
//                    }
//                    finally
//                    {
//                        Console.WriteLine("Try again? (y/n)");
//                        string answer = Console.ReadLine();
//                        if (answer == "n")
//                        {
//                            loop3 = false;
//                        }
//                    }
//                }

//                Console.WriteLine("\nFarewell.. Thanks for using our fine software!");
//                Console.ReadLine();
//            }
//        }
//    }
//}






//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MainMethodAssignment
//{
//    internal class Math
//    {
//        // Create an Operation method that takes an integer parameter
//        public int Operation(int num1)
//        {
//            return num1 + 5;
//        }

//        // Create an Operation method that takes a double parameter
//        public double Operation(double num1)
//        {
//            return num1 - 5;
//        }

//        // Create an Operation method that takes a string parameter
//        public int Operation(string num1)
//        {
//            int Newnum1 = Convert.ToInt32(num1);
//            return Newnum1 * 5;
//        }

//    }
//}