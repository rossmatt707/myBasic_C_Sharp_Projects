using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission4
{
    // Internal class with a void method
    internal class VoidClass
    {
        // Public Void method that takes an integer and divides it by two
        public void DivideByTwo(int num1, out int result)
        {
            result = num1 / 2;
        }
    }

    // Static class with two overloaded methods
    internal static class StaticClass
    {
        // Static method that takes two out parameters
        public static void GetOutput(out int number, out string message)
        {
            number = 777;
            message = "Hello!";
        }

        // Static method that takes a string input and an out parameter
        public static void GetOutput(string input, out string message2)
        {
            // Concatenating the input with a message
            message2 = $"This is what you wanted to tell the people:";
        }
    }
    
}
