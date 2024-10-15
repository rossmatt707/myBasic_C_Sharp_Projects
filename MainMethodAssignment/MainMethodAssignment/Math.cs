using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Math
    {
        // Create an Operation method that takes an integer parameter
        public int Operation(int num1)
        {
            return num1 + 5;
        }

        // Create an Operation method that takes a double parameter
        public double Operation(double num1)
        {
            return num1 - 5;
        }

        // Create an Operation method that takes a string parameter
        public int Operation(string num1)
        {
            int Newnum1 = Convert.ToInt32(num1);
            return Newnum1 * 5;
        }
        
    }
}
