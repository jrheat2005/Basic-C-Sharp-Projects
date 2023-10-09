using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    // Define a class with two constructors.
    class MyClass
    {
        private string _name;

        // Constructor with a single parameter.
        public MyClass(string name)
        {
            _name = name;
        }

        // Constructor chaining - calls another constructor.
        public MyClass() : this("Default Name")
        {
        }

        // Method to display a message using the _name field.
        public void DisplayMessage()
        {
            Console.WriteLine($"Hello, {_name}!");
        }
    }
}
