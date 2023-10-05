using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    // Create an Employee class with a generic type parameter
    public class Employee<T>
    {
        // Add a property called "Things" with a generic list matching the generic type of the class
        public List<T> Things { get; set; } = new List<T>(); // Initialize the list in the property declaration
    }

}
