using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Get package weight  
            Console.Write("Enter package weight: ");
            int weight = Int32.Parse(Console.ReadLine());

            // Validate weight 
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            // Get dimensions
            Console.Write("Enter package width: ");
            int width = Int32.Parse(Console.ReadLine());

            Console.Write("Enter package height: ");
            int height = Int32.Parse(Console.ReadLine());

            Console.Write("Enter package length: ");
            int length = Int32.Parse(Console.ReadLine());

            // Validate dimensions
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculate quote
            int volume = width * height * length;
            double quote = (volume * weight) / 100.0;

            // Output quote 
            Console.WriteLine("Your estimated total for shipping this package is: ${0}", quote);
            Console.ReadLine();

        }
    }
}
