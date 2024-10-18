using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number: "); // Prompt user to enter a number
            string num = Console.ReadLine(); // Read the number entered by the user
            File.WriteAllText(@"D:\Basic_C#_Programs\InputAssignment\InputAssignment\log.txt", num); // Write the number to a txt file
            string fileContent = File.ReadAllText(@"D:\Basic_C#_Programs\InputAssignment\InputAssignment\log.txt"); // Read the number from the txt file and save as a string
            Console.WriteLine("The number you entered is: " + fileContent); // Display the number entered by the user
            Console.ReadLine();

        }
    }
}
