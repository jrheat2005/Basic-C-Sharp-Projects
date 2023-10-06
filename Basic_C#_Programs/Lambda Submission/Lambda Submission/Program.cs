using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" },
            new Employee { Id = 3, FirstName = "Bob", LastName = "Wilson" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Eva", LastName = "Lee" },
            new Employee { Id = 6, FirstName = "Chris", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Joe", LastName = "Roberts" },
            new Employee { Id = 8, FirstName = "Maria", LastName = "Gonzalez" },
            new Employee { Id = 9, FirstName = "John", LastName = "Clark" },
            new Employee { Id = 10, FirstName = "Sarah", LastName = "Miller" }
        };

            Console.WriteLine("Employees with the first name 'Joe' (using foreach loop):");
            List<Employee> joes = new List<Employee>();

            // Using a foreach loop to filter employees with the first name "Joe"
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joes.Add(emp);
                }
            }

            foreach (Employee joe in joes)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with the first name 'Joe' (using lambda expression):");

            // Using a lambda expression to filter employees with the first name "Joe"
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with an Id greater than 5 (using lambda expression):");

            // Using a lambda expression to filter employees with an Id greater than 5
            List<Employee> idGreaterThan5 = employees.Where(emp => emp.Id > 5).ToList();

            foreach (Employee emp in idGreaterThan5)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            Console.ReadLine(); // Keep the console window open.
        }
    }
}
