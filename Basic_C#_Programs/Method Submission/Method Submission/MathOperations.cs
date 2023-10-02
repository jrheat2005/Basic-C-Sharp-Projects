using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission
{
    public class MathCalculator
    {
        // Created a method that takes two integers as parameters, with one of them optional (default value is 0).
        public int PerformMathOperation(int number1, int number2 = 0)
        {
            // Add the numbers together
            int result = number1 + number2;
            return result;
        }
    }
}
