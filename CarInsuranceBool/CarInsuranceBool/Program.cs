using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceBool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user for age
            Console.WriteLine("What is your age?");
            // Converts user input to integer
            int age = Convert.ToInt32(Console.ReadLine());
            // Asks user if they have had a DUI
            Console.WriteLine("Have you ever had a DUI? Answer 'true' or 'false'.");
            // Converts user input to boolean
            bool dui = Convert.ToBoolean(Console.ReadLine());
            // Asks user how many speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            // Converts user input to integer
            int tickets = Convert.ToInt32(Console.ReadLine());
            // Prints out a question asking if the user qualifies for the car insurance policy
            Console.WriteLine("Do you qualify for our car insurance policy?");
            // Creates a boolean variable that checks if the user is over 15 years old, has no DUI, and has less than 3 speeding tickets
            bool qualify = (age > 15 && dui == false && tickets <= 3);
            // Prints out the users age, if they have had a DUI, how many speeding tickets they have, and if they qualify for the car insurance policy
            Console.WriteLine("\nYour age is: " + age + "\nHave you ever had a DUI? " + dui + "\nHow many speeding tickets do you have? " + tickets + "\ndo you qualify for our car insurance policy? " + qualify);
            Console.ReadLine();
        }
    }
}
