using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Method to write full name to console
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

// Employee class inherits from Person
public class Employee : Person
{
    // Additional ID property
    public int Id { get; set; }
}