using System;

// Create a class called Calculator
class Calculator
{
    // Create a void method called DivideByTwo that takes an integer as input and divides it by 2.
    public void DivideByTwo(int number)
    {
        int result = number / 2;
        Console.WriteLine($"Result of division: {result}");
    }

    // Overload the DivideByTwo method to accept a double and divide it by 2.
    public void DivideByTwo(double number)
    {
        double result = number / 2.0;
        Console.WriteLine($"Result of division: {result}");
    }

    // Create a method with output parameters to calculate the sum and product of two numbers.
    public void CalculateSumAndProduct(int num1, int num2, out int sum, out int product)
    {
        sum = num1 + num2;
        product = num1 * num2;
    }
}
