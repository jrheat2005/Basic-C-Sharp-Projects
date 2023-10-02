using System;

public class MathOperations
{

    // Adds 10 to an integer and returns the result
    public int AddTen(int number)
    {
        return number + 10;
    }

    // Adds 10 to a decimal, converts to int, and returns the result
    public int AddTen(decimal number)
    {
        return (int)(number + 10);
    }

    // Converts string to int, adds 10, and returns the result
    public int AddTen(string numberText)
    {
        int number = int.Parse(numberText);
        return number + 10;
    }

}