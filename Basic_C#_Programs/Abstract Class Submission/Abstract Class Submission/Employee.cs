using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public new void SayName()
        {
            Console.WriteLine($"Employee Name: {FirstName} {LastName} {Id}");
        }
    }
}
