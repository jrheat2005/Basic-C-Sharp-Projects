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
            if (int.TryParse(input2Str, out input2))
            {
                // Call method
                int result = calc.PerformMathOperation(input1, input2);

                // Display result
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                // Input is invalid
                Console.WriteLine("Invalid input for the second number.");
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