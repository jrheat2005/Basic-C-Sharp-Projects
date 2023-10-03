using System;

public class MathCalculator
{
    // Create a method that takes two integers as parameters, with one of them optional (default value is 0).
    public int PerformMathOperation(int number1, int number2 = 0)
    {
        // Add the two numbers together
        int result = number1 + number2;
        return result;
    }
}