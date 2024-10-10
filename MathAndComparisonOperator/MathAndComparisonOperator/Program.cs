using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program will compare the annual salary of two people
            Console.WriteLine("Anonymous Income Comparison Program");
            // Person 1
            Console.WriteLine("Person 1");
            // Ask for hourly rate
            Console.WriteLine("What is your hourly rate?");
            string rate1 = Console.ReadLine();
            // Ask for hours worked per week
            Console.WriteLine("How many hours do you work per week?");
            string hours1 = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string rate2 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hours2 = Console.ReadLine();

            // Converts all string variables to double variables for calculations involving possible decimals.
            double rate1Double = Convert.ToDouble(rate1);
            double rate2Double = Convert.ToDouble(rate2);
            double hours1Double = Convert.ToDouble(hours1);
            double hours2Double = Convert.ToDouble(hours2);

            // Calculates the annual salary of each person
            double salary1 = rate1Double * hours1Double;
            double salary2 = rate2Double * hours2Double;
            Console.WriteLine("Annual salary of Person 1: " + salary1);


            // Prints the annual salary of each person
            Console.WriteLine("Annual salary of Person 2: " + salary2);
            bool compare = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + compare);
            Console.ReadLine();


        }
    }
}
