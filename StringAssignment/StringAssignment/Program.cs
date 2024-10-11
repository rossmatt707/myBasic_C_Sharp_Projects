using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating three string variables
            string Name = "Mark";
            string Name2 = "Josh";
            string Name3 = "Sally";
            // Concatenate three strings.
            string sentence = "Best friends through thick and thin.. " + Name + ", " + Name2 + ", and " + Name3 + "!";
            // Print the sentence to the console.
            Console.WriteLine(sentence);

            // Prints this message to the console with line breaks before and after.
            Console.WriteLine("\nLouder now.. and with feeling.\n");
            // Convert the string to uppercase.
            string upperCase = sentence.ToUpper();
            // Print the result to the console.
            Console.WriteLine(upperCase);


            // Create a StringBuilder and build a paragraph of text.
            StringBuilder sb = new StringBuilder();
            // Append the first sentence to the StringBuilder.
            sb.Append("We are the best of friends.. ");
            // Append the second sentence to the StringBuilder.
            sb.Append("and we will be friends forever. ");
            // Append the third sentence to the StringBuilder.
            sb.Append("We will always be there for each other. ");
            // Append the fourth sentence to the StringBuilder.
            sb.Append("\nNow trade me your holographic charizard!");
            // Print the result to the console.
            Console.WriteLine(sb);
        }
    }
}








