using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking and storing all the data 
            Console.WriteLine("Please answser the questions below");
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Please anwser in true or false)");
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speeding = int.Parse(Console.ReadLine());

            // check if over 15
            bool overAge = 15 < age;

            // check if under 3 tickets
            bool speedingNumber = 3 >= speeding;

            // checking if it passes all the qualifcations
            bool qualified = overAge && speedingNumber ^ dui;

            // display results
            Console.WriteLine("What is your age?\n" + age);
            Console.WriteLine("Have you ever had a DUI?\n" + dui);
            Console.WriteLine("How many speeding tickets do you have?\n" + speeding);
            Console.WriteLine("Qualified?\n" + qualified);

            // wait before closing
            Console.ReadLine();
        }
    }
}
