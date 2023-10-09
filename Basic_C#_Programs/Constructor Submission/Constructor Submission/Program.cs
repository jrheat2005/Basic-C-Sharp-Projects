using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Program
    {
        // Create a const variable.
        const int MaxValue = 100;

        static void Main(string[] args)
        {
            // Create a variable using the keyword "var."
            var message = "Hello, World!";

            // Display the constant and var variables.
            Console.WriteLine($"Max Value: {MaxValue}");
            Console.WriteLine($"Message: {message}");

            // Create an instance of MyClass, chaining two constructors.
            MyClass myObject = new MyClass("John");
            myObject.DisplayMessage();
            Console.ReadLine();
        }
    }

    
}
