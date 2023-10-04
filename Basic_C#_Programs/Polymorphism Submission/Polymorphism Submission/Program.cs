using System;

namespace Polymorphism_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee emp = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                EmployeeId = 12345
            };

            // Call the SayName method on the Employee object
            emp.SayName();

            // Create an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = emp;

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
