using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare Employee objects by their Id property
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        // Overload the "!=" operator to complement the "==" operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1.Id == employee2.Id);
        }
    }
}
