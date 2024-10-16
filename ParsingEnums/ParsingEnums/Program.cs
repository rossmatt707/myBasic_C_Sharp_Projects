using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isDay = false; // Flag to check if a valid day is entered

            while (!isDay) // Loop until a valid day is entered
            {
                try
                {
                    Console.WriteLine("Enter the current day of the week: "); // Prompt user to enter a day of the week
                    string currentDay = Console.ReadLine();// Read the input from the user

                    Days day; // Declare a variable of type Days
                    if (Enum.TryParse(currentDay, true, out day)) // Try to parse the input to an enum
                    {
                        Console.WriteLine("The day of the week is: " + day); // if parse succesful display the day of the week
                        isDay = true; // Set the flag to true to exit the loop
                    }
                    else // If the input is not a valid day of the week
                    {
                        Console.WriteLine("Please enter an actual day of the week."); // Display an error message
                    }
                }
                catch (Exception ex) // Catch any exceptions that may occur
                {
                    Console.WriteLine("An error occurred: " + ex.Message); // Display the error message
                }

            }                                                          
        }
        // Enum for days of the week
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
