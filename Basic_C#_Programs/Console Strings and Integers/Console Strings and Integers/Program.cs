using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers.
        List<int> numbers = new List<int> { 100, 200, 300, 400, 500 };

        try
        {
            // Ask the user for a number to divide each number in the list by.
            Console.Write("Enter a number to divide by: ");
            string input = Console.ReadLine();

            // Attempt to parse the user input to an integer.
            int divisor;

            if (int.TryParse(input, out divisor))
            {
                // Write a loop that takes each integer in the list, divides it by the user's input, and displays the result.
                foreach (int number in numbers)
                {
                    // Check if the divisor is zero to avoid division by zero.
                    if (divisor == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }

                    int result = number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} is {result}");
                }
            }
            else
            {
                // If parsing fails, inform the user that the input is not a valid number.
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        catch (DivideByZeroException ex)
        {
            // Catch and display the error message for division by zero.
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // Display a message to let the user know the program has emerged from the try/catch block.
            Console.WriteLine("Program has continued execution.");
        }
        Console.ReadLine();
    }
}
