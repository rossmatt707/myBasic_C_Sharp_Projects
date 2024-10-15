using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission3Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the VoidClass
            var voidClass = new VoidClass();
            // Call the VoidMethod and pass in two integers using position
            voidClass.VoidMethod(25, 13245);
            // Call the VoidMethod and pass in two integers by name
            voidClass.VoidMethod(num1: 25, numVoid: 13245);
            Console.ReadLine();
        }
    }
}



