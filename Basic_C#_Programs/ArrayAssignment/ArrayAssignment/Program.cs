using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array of strings
            string[] names = { "Bob", "Kate", "Sam", "Tim"};

            // Prompt user for a number and display value
            Console.Write("Enter index for names array: ");
            int nameIndex = Int32.Parse(Console.ReadLine());

            if(nameIndex >= 0 && nameIndex < names.Length)
            {
                Console.WriteLine(names[nameIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            // Create array of ints
            int[] numbers = { 1, 5, 7, 9 };

            // Prompt user for a number and display value
            Console.Write("Enter index for numbers array: ");
            int numIndex = Int32.Parse(Console.ReadLine());

            if (numIndex >= 0 && numIndex < numbers.Length)
            {
                Console.WriteLine(numbers[numIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            // Create list of strings 
            List<string> colors = new List<string>() { "Red", "Green", "Blue", "Yellow" };

            // Prompt for index and display value
            Console.Write("Enter index for colors list: ");
            int colorIndex = Int32.Parse(Console.ReadLine());

            if (colorIndex >= 0 && colorIndex < colors.Count)
            {
                Console.WriteLine(colors[colorIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            Console.ReadLine();
        }
    }
}
