using System;

class Program
{
    static void Main(string[] args)
    {
        MathCalculator calc = new MathCalculator();

        // Get input 1
        Console.Write("Enter first number: ");
        int input1;

        if (int.TryParse(Console.ReadLine(), out input1))
        {
            // Get input 2
            Console.Write("Enter second number (optional): ");
            string input2Str = Console.ReadLine();

            int input2;

            if (string.IsNullOrWhiteSpace(input2Str))
            {
                // If input2 is empty or whitespace, use the default value (0)
                int result = calc.PerformMathOperation(input1); // Call with one parameter
                Console.WriteLine($"Result: {result}");
            }
            else if (int.TryParse(input2Str, out input2))
            {
                // Input is valid, call with both parameters
                int result = calc.PerformMathOperation(input1, input2);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                // Input is invalid, but we'll use the default value (0)
                Console.WriteLine("Invalid input for the second number. Using the default value (0).");
                int result = calc.PerformMathOperation(input1); // Call with one parameter
                Console.WriteLine($"Result: {result}");
            }
        }
        else
        {
            // Input is invalid
            Console.WriteLine("Invalid input for the first number.");
        }

        // Wait for key press
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}