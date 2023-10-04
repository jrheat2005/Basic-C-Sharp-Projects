using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Submission
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to write the full name to the console
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
