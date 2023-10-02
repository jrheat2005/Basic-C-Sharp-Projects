using System;

class Program
{
    static void Main()
    {
        // Ask the user for a number to perform math operations on
        Console.Write("Enter a number: ");

        try
        {
            // Read the user input as a string
            string userInput = Console.ReadLine();

            // Convert the user input to an integer
            int userNumber = int.Parse(userInput);

            // Call each method from the MathOperations class and display the results
            int result1 = MathOperations.AddTen(userNumber);
            Console.WriteLine($"Adding 10 to {userNumber} gives: {result1}");

            int result2 = MathOperations.SubtractFive(userNumber);
            Console.WriteLine($"Subtracting 5 from {userNumber} gives: {result2}");

            int result3 = MathOperations.MultiplyByTwo(userNumber);
            Console.WriteLine($"Multiplying {userNumber} by 2 gives: {result3}");
        }
        catch (FormatException)
        {
            // Handle the case where the user enters a non-integer string
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            // Handle any other unexpected exceptions
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        // This line will be executed after the try/catch block
        Console.WriteLine("Program finished.");
        Console.ReadLine();
    }
}
