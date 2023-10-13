using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age.
                Console.Write("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Check if the age is zero or negative and handle it as an exception.
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age must be a positive number.");
                }

                // Calculate the birth year by subtracting the age from the current year.
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display the year the user was born.
                Console.WriteLine($"You were born in the year {birthYear}.");
            }
            catch (FormatException)
            {
                // Handle the exception if the user enters non-numeric input.
                Console.WriteLine("Invalid input. Please enter a valid age as a number.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle the exception if the age is zero or negative.
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions.
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for the user to press any key before exiting the program.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}