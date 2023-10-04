using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to write full name to console
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
