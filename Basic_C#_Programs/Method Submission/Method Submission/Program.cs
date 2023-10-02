using Method_Submission;
using System;

class Program
{
    static void Main()
    {
        // Ask the user for a number
        Console.Write("Enter a number for math operations: ");

        try
        {
            // Read the user input as a string
            string userInput = Console.ReadLine();

            // Convert the user input to an integer
            int number = int.Parse(userInput);

            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call each method and display the results
            int result1 = mathOps.AddTen(number);
            int result2 = mathOps.SubtractFive(number);
            int result3 = mathOps.MultiplyByTwo(number);

            Console.WriteLine($"Result of adding 10: {result1}");
            Console.WriteLine($"Result of subtracting 5: {result2}");
            Console.WriteLine($"Result of multiplying by 2: {result3}");
        }
        catch (FormatException)
        {
            // Handle the case where the user enters non-integer input
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            // Handle any other unexpected exceptions
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
