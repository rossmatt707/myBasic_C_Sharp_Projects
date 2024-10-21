using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment398
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person(); // This is the default constructor
            const string greeting = "Hello!"; // This is a constant string
            var luckyNumber = 8; // This is a var variable
            Console.WriteLine(greeting); // Constant string is printed to the console
            Console.WriteLine($"\nName: {person.FirstName} {person.LastName}, Age: {person.Age}, Political Party: {person.PoliticalParty}"); // The default constructor values are printed to the console
            Console.WriteLine($"\nYour lucky number is {luckyNumber}."); // The lucky number var variable is printed to the console
            Console.ReadLine(); // The console waits for the user to press enter before closing


        }
    }
}
