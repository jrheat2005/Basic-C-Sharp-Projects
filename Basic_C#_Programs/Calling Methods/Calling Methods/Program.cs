using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Math class
            Math math = new Math();

            // Ask the user for a integer input
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int UserInput))
            {
                // Call each method and display the results
                int doubled = math.Double(UserInput);
                int squared = math.Square(UserInput);
                int factorial = math.Factorial(UserInput);

                Console.WriteLine($"Double: {doubled}");
                Console.WriteLine($"Square: {squared}");
                Console.WriteLine($"Factorial: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadLine();
        }
    }
}
