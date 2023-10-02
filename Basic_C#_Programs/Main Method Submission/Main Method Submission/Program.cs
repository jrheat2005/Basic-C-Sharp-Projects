using System;

class Program
{
    static void Main()
    {
        // Instantiate MathOperations class
        MathOperations math = new MathOperations();

        // Get input from user
        Console.Write("Enter an integer: ");
        int userNumber = int.Parse(Console.ReadLine());

        // Call method with int parameter
        int result1 = math.AddTen(userNumber);
        Console.WriteLine(result1);

        // Call method with decimal parameter 
        decimal userDecimal = 3.5M;
        int result2 = math.AddTen(userDecimal);
        Console.WriteLine(result2);

        // Call method with string parameter
        string userText = "5";
        int result3 = math.AddTen(userText);
        Console.WriteLine(result3);
        Console.ReadLine();
    }
}