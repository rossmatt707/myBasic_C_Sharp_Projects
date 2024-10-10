using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace DoWhileConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop
            int count = 0;
            // Loop continues while count is less than 5
            while (count < 10)
            {
                // Writes count value to console
                Console.WriteLine("Count: " + count);
                // Increments count by 1
                count++;
                // Pauses for 500 milliseconds
                Thread.Sleep(500);
            }
            if (count == 10)
            {
                // Writes "Happy new year!" to console when count is 10
                Console.WriteLine("Happy new year!");
            }
            // Resets count to 0
            count = 0;
            // Line break
            Console.WriteLine("\n");
            // Do-While loop
            do
            {
                // Writes count value to console
                Console.WriteLine("Count: " + count);
                // Increments count by 1
                count++;
                // Pauses for 500 milliseconds
                Thread.Sleep(500);
            }
            // Loop continues while count is less than 5
            while (count < 10);
            if (count == 10) 
            {
                // Writes "Happy new year!" to console when count is 10
                Console.WriteLine("Happy new year!");
            }
        }
    }
}
