using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    static class Program
    {
        static void Main()
        {
            // Instantiate the Calculator class.
            Calculator calculator = new Calculator();

            // Prompt the user to enter a number.
            Console.Write("Enter a number: ");
            int userInput;

            // Ensure that the user enters a valid integer.
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            // Call the DivideByTwo method on the user's input and display the result.
            calculator.DivideByTwo(userInput);

            // Demonstrate method overloading by calling the DivideByTwo method with a double.
            double doubleInput = userInput;
            calculator.DivideByTwo(doubleInput);

            // Declare variables to store the sum and product.
            int sum, product;

            // Call the CalculateSumAndProduct method with output parameters.
            calculator.CalculateSumAndProduct(userInput, 3, out sum, out product);

            // Display the sum and product.
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");

            Console.ReadLine(); // Keep the console window open.
        }
    }
}
