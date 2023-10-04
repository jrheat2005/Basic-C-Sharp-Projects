using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Submission
{
    public class Employee : Person, IQuittable
    {
        public int EmployeeId { get; set; }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} Id: {EmployeeId} has quit the job.");
        }
    }
}
