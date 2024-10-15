using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringAndIntegerAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Start of try/catch block.
                try
                {
                    // List of integers.
                    List<int> Ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                    // Ask user for a number.
                    Console.WriteLine("Please enter a number and we\'ll divide it into all the numbers on our list.");
                    // User input.
                    string userInput = Console.ReadLine();
                    // Convert user input to decimal.
                    decimal userNumber = Convert.ToDecimal(userInput); 
                    // Loop through list of integers and divide each by user input.
                    foreach (int i in Ints)
                    {
                        // Divide i by userNumber and store result in decimal variable. 
                        decimal result = i / userNumber;
                        // Output result to console using string interpolation.
                        Console.WriteLine($"{i} divided by {userNumber} equals {result:F4}");
                        // Pause for half a second.
                        Thread.Sleep(500);                     
                    }
                    // Break out of while loop if operation completed.
                    break;
                }
                // Catch exceptions.
                catch (DivideByZeroException ex)
                {
                    // Output message to console for this exception.
                    Console.WriteLine("Please don't divide by zero.");                   
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Input invalid... Please type a number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error occured: {ex.Message}");
                }
                // Finally block.
                finally
                {
                    Console.ReadLine();
                }
                
            }
            // End of try/catch block.
            Console.WriteLine("Program has exited the try/catch block.");
            Console.ReadLine();
        }
    }
}



// Copy for reference

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExceptionHandlingVideo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Pick a number.");
//                int numberOne = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Pick a second number.");
//                int numberTwo = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Dividing the two numbers...");
//                int numberThree = numberOne / numberTwo;
//                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
//                Console.ReadLine();
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine("Please type a whole number.");
//                return;
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Please don\'t divide by zero.");
//                return;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//                return;
//            }
//            finally
//            {
//                Console.ReadLine();
//            }
//            Console.ReadLine();
//        }
//    }
//}