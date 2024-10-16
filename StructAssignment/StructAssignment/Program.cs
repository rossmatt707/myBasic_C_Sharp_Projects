using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number number1 = new number(); // create an object of number struct
            number1.Amount = (decimal)10.5; // assign value to Amount and cast it to decimal
            Console.WriteLine(number1.Amount); // print the value of Amount
            Console.ReadLine(); // wait for user input
        }
        public struct number // create a struct named number
        {
            public decimal Amount; // create a public decimal variable named Amount
        }
    }
}
