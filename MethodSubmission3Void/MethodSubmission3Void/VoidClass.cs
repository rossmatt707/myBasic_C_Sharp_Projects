using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MethodSubmission3Void
{
    internal class VoidClass
    {
        // Void method that takes two integers as parameters
        public void VoidMethod(int num1, int numVoid)
        {
            // Multiply the first integer by 4
            num1 = num1 * 4;
            // Display the result of the multiplication
            Console.WriteLine($"Your first number multiplied by four is {num1}!");
            Thread.Sleep(1000);
            // Display the second integer
            Console.WriteLine($"Your second void number.. don't worry we left it alone: {numVoid}");
        }
    }
}
