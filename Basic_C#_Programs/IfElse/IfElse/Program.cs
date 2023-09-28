using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            if (name == "John")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }

            if (name != "John")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }

            int age = 14;
            if (age <= 21)
            {
                Console.WriteLine("Old enough");
            }
            else
            {
                Console.WriteLine("Not old enough");
            }
            if (age > 21)
            {
                Console.WriteLine("Old enough");
            }
            else
            {
                Console.WriteLine("Not old enough");
            }

            int num1 = 17;
            int num2 = 19;

            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
