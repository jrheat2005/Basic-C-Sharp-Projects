using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                userInput = userInput.ToLower();

                // Check if the input matches any enum value
                if (Enum.IsDefined(typeof(DaysOfWeek), userInput))
                {
                    // Parse the user input into an enum value (DaysOfWeek)
                    DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                    string capitalizedDay = char.ToUpper(currentDay.ToString()[0]) + currentDay.ToString().Substring(1);
                    // Print the assigned value
                    Console.WriteLine($"The current day of the week is: {capitalizedDay}");
                }
                else
                {
                    // Display an error message if the input doesn't match any enum value
                    Console.WriteLine("Please enter a valid day of the week.");
                }
            }
            catch (Exception ex)
            {
                // Catch any other exceptions that may occur
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadLine(); // Keep the console window open.
        }
    }
    enum DaysOfWeek
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }
}
