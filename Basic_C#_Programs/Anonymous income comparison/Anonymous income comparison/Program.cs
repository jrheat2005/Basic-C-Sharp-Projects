using System;

namespace Anonymous_income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1");

            // asking and storing the hourly rate for person 1
            Console.WriteLine("Please input hourly rate? ");
            decimal hourlyRate1 = decimal.Parse(Console.ReadLine());

            // asking and storing the hours worked for person 1
            Console.Write("Please input hours worked this week? ");
            int hoursWorked1 = int.Parse(Console.ReadLine());

            // title
            Console.WriteLine("Person 2");

            // asking and storing the hourly rate for person 2
            Console.Write("Please input hourly rate? ");
            decimal hourlyRate2 = decimal.Parse(Console.ReadLine());

            // asking and storing the hours worked for person 2
            Console.Write("Please input hours worked this week? ");
            int hoursWorked2 = int.Parse(Console.ReadLine());

            // converting to weekly salary
            decimal weeklySalary1 = hourlyRate1 * hoursWorked1;
            decimal weeklySalary2 = hourlyRate2 * hoursWorked2;

            // converting to annual salary
            decimal annualSalary1 = weeklySalary1 * 52;
            decimal annualSalary2 = weeklySalary2 * 52;

            // checking if the person 1 made more than person 2
            bool comparison = weeklySalary1 > weeklySalary2;

            // display annual incomes plus show the results of the comparison of the two salaries
            Console.WriteLine("Annual salary of Person 1: $" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: $" + annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2? " + comparison);
        }
    }
}
