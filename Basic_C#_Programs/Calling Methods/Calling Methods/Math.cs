using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public class Math
    {
        // Method to double the input integer
        public int Double(int num)
        {
            return num * 2;
        }

        // Method to square the input integer
        public int Square(int num)
        {
            return num * num;
        }

        // Method to calculate the factorial of the input integer
        public int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }