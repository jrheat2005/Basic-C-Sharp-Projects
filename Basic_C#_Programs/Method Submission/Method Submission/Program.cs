using System;
class Program
{
    static void Main()
    {
        // Instantiate the MathCalculator class
        MathCalculator calculator = new MathCalculator();

        // Ask the user to input two numbers, one at a time
        Console.Write("Enter the first number: ");
        int input1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (press Enter to skip): ");
        string input2Str = Console.ReadLine();

        int input2;

        try
        {
            // Try to parse the second input as an integer
            input2 = int.Parse(input2Str);
        }
        catch (FormatException)
        {
            // Handle the case where the second input is not a valid integer
            Console.WriteLine("Invalid input for the second number. Using the default value (0).");
            input2 = 0;
        }

        // Call the PerformMathOperation method with the provided inputs
        int result = calculator.PerformMathOperation(input1, input2);

        // Display the result
        Console.WriteLine($"Result of the math operation: {result}");

        // Wait for user input before exiting (optional)
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}