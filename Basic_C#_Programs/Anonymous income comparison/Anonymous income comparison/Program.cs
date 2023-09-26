using System;

namespace Anonymous_income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1");


            Console.WriteLine("Please input hourly rate? ");
            decimal hourlyRate1 = decimal.Parse(Console.ReadLine());


            Console.Write("Please input hours worked this week? ");
            int hoursWorked1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.Write("Please input hourly rate? ");
            decimal hourlyRate2 = decimal.Parse(Console.ReadLine());


            Console.Write("Please input hours worked this week? ");
            int hoursWorked2 = int.Parse(Console.ReadLine());

            decimal weeklySalary1 = hourlyRate1 * hoursWorked1;
            decimal weeklySalary2 = hourlyRate2 * hoursWorked2;


            decimal annualSalary1 = weeklySalary1 * 52;
            decimal annualSalary2 = weeklySalary2 * 52;

            bool comparison = weeklySalary1 > weeklySalary2;

            Console.WriteLine("Annual salary of Person 1: $" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: $" + annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2? " + comparison);
        }
    }
}
