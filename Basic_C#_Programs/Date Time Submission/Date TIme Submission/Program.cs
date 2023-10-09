using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_TIme_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console.
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDateTime);

            try
            {
                // Ask the user for a number.
                Console.Write("Enter a number of hours: ");
                string userInput = Console.ReadLine();

                // Convert the user input to an integer.
                int hours = int.Parse(userInput);

                // Calculate the exact time it will be in X hours.
                DateTime futureDateTime = currentDateTime.AddHours(hours);
                Console.WriteLine($"In {hours} hours, it will be: {futureDateTime}");
            }
            catch (FormatException)
            {
                // Handle the case where the user input is not a valid integer.
                Console.WriteLine("Invalid input. Please enter a valid number of hours.");
            }
            catch (Exception ex)
            {
                // Handle other unexpected exceptions.
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Wait for the user to press any key before exiting the program.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}