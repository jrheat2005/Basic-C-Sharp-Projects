using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // take input and mutiply by 50
            Console.Write("Enter a number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            num1 = num1 * 50;
            Console.WriteLine(num1);

            // take input and add 25 
            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());
            num2 += 25;
            Console.WriteLine(num2);

            // take input and divide by 12.5
            Console.Write("Enter a number: ");
            double num3 = double.Parse(Console.ReadLine());
            num3 /= 12.5;
            Console.WriteLine(num3);

            // take input check if greater than 50, than print true or false accordingly 
            Console.Write("Enter a number: ");
            int num4 = int.Parse(Console.ReadLine());
            bool isGreater = num4 > 50;
            Console.WriteLine(isGreater);

            // take input and divide by 7 and print the remainder
            Console.Write("Enter a number: ");
            int num5 = int.Parse(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
