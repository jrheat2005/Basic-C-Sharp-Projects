﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Five minus Ten = " + difference.ToString());
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool comparison = 11 < 2;
            //Console.WriteLine(comparison);
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 72;

            bool isWarm = currentTemp == roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
