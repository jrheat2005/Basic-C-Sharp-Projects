using System;
using System.Collections.Generic;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
// Assignment 1
            string[] strings = { "Hello ", "See You Later ", "Goodbye " };

            // Ask the user for a string to append to the text
            Console.Write("Enter text to append: ");
            string userInput = Console.ReadLine();

            // Add the user input to the strings
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] += userInput;
            }

            // Display each string
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

// Assignment 2
            while (true) // Infinite loop with true condition
            {

                // I added a condition to exit the loop
                Console.Write("Do you want to exit the infinite loop? (yes/no): ");
                string input = Console.ReadLine().ToLower();

                if (input == "yes")
                {
                    break; // Exit the loop if the user enters "yes"
                }
            }

// Assignment 3:
            Console.WriteLine("\nLoop with '<' operator:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("\nLoop with '<=' operator:");
            for (int j = 0; j <= 5; j++) // Loop while j is less than or equal to 5
            {
                Console.WriteLine("j = " + j);
            }

// Assignment 4
            List<string> uniqueStrings = new List<string>
            {
                "Apple",
                "Banana",
                "Cherry",
                "Grapes",
                "Orange",
                "Pear"
            };

            // Ask the user to input text to search for in the list
            Console.Write("Enter text to search in the list: ");
            string searchText = Console.ReadLine();

            bool found = false;

            // Loop that iterates through the list and displays the index of the matching item
            for (int i = 0; i < uniqueStrings.Count; i++)
            {
                if (uniqueStrings[i].ToLower().Contains(searchText.ToLower()))
                {
                    Console.WriteLine($"Found '{searchText}' at index {i}");
                    found = true;
                    break; // Stop the loop once a match is found
                }
            }

            // Check if the user input text that isn't on the list
            if (!found)
            {
                Console.WriteLine($"'{searchText}' is not found in the list.");
            }

 // Assignment 5
            List<string> stringList = new List<string>
            {
                "Apple",
                "Banana",
                "Cherry",
                "Apple", 
                "Grapes",
                "Apple"  
            };

            // Ask the user to enter text to search for
            Console.Write("Enter text to search in the list: ");
            string searchText2 = Console.ReadLine();

            bool found2 = false;

            // Loop to search and display indices of matching items
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Equals(searchText2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found '{searchText2}' at index {i}");
                    found2 = true;
                }
            }

            // Check if the user input text is not in the list
            if (!found2)
            {
                Console.WriteLine($"'{searchText2}' is not found in the list.");
            }


// Assignment 6
            // List of strings
            List<string> stringList2 = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "C"
            };

            // Create a dictionary to keep track of seen strings
            Dictionary<string, int> seenStrings = new Dictionary<string, int>();

            // Iterate through the list
            foreach (string item in stringList2)
            {
                // Check if the string has already appeared in the list
                if (seenStrings.ContainsKey(item))
                {
                    // If it has appeared before, indicate it's a duplicate
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    // If it's the first appearance, mark it as seen
                    seenStrings[item] = 1;
                    Console.WriteLine($"{item} - this item is unique");
                }
            }

            // Wait for user input
            Console.ReadLine();
        }
    }
}
