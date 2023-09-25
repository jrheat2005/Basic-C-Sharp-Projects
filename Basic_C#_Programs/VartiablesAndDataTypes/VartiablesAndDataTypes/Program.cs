using System;

namespace VartiablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a simple program
            //Console.Writeline("what is your name?");
            //string yourname = console.readline();
            //Console.Writeline("your name is: " + yourname);
            //Console.Readline();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currenTemp = -32;
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.30220304;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;
            string myName = "Josh";

            int currentAge = 30;
            string yearOld = currentAge.ToString();
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
        }
    }
}
