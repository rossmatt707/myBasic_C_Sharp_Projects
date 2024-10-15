using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassSubmission4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the VoidClass
            VoidClass voidClass = new VoidClass();

            Console.WriteLine("Please enter a number: "); // Prompting the user to enter a number
            int num1 = Convert.ToInt32(Console.ReadLine()); // Converting the user input to an integer

            int result; // Declaring the result variable
            voidClass.DivideByTwo(num1, out result); // Calling the DivideByTwo method and passing arguments
            Console.WriteLine($"Your number divided by two is {result}!"); // Displaying the result
            Thread.Sleep(1000); // Pausing the program for 1 second

            StaticClass.GetOutput(out int number, out string message); // Calling the GetOutput method with two out parameters
            Console.WriteLine($"\nThe number is {number} and the message is {message}."); // Displaying the output
            Thread.Sleep(1000); // Pausing the program for 1 second

            Console.WriteLine("\nPlease enter a message: "); // Prompting the user to enter a message
            string input = Console.ReadLine(); // Storing the user input in a variable
            StaticClass.GetOutput(input, out string message2); // Calling the GetOutput method with a string input and an out parameter
            Console.WriteLine($"{message2} {input}"); // Displaying the output
            Console.ReadLine(); // Keeping the console window open
        }
    }   
}
