using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Employee object
            Employee emp = new Employee();

            // Initialize properties
            emp.FirstName = "Sample";
            emp.LastName = "Student";

            emp.SayName();
            Console.ReadLine();
        }
        
    }
}