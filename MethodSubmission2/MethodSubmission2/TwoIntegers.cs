using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission2
{
    internal class Math
    {
        // Operation method that can take two integers with the second integer being optional
        public int TwoInt(int num1, int num2 = 0)
        {
            return num1 + num2;
        }

    }
}