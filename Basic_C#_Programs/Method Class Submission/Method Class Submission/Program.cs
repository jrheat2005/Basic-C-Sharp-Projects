using System;

namespace Method_Class_Submission
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method in the class, passing in two numbers
            mathOps.PerformMathOperationAndDisplay(10, 20);

            // Call the method in the class, specifying parameters by name
            mathOps.PerformMathOperationAndDisplay(num1: 15, num2: 25);

            // Wait for user input before exiting (optional)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
