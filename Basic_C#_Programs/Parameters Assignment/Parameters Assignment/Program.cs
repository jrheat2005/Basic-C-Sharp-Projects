using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string" as its generic parameter
            Employee<string> stringEmployee = new Employee<string>
            {
                Things = { "Apple", "Banana", "Cherry" } // Initialize the list using collection initializer
            };

            // Instantiate an Employee object with type "int" as its generic parameter
            Employee<int> intEmployee = new Employee<int>
            {
                Things = { 1, 2, 3 } // Initialize the list using collection initializer
            };

            // Print the Things for both Employee objects
            Console.WriteLine("Strings:");
            foreach (string thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nIntegers:");
            foreach (int thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine(); // Keep the console window open.
        }
    }

}
