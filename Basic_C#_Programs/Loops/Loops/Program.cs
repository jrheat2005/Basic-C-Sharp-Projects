using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize counter variable
            int counter = 0;

            // Loop while counter is less than 5
            while (counter < 5)
            {

                // Print counter
                Console.WriteLine(counter);

                // Plus one
                counter++;

            }

            int counter2 = 0;

            // Do-while
            do
            {

                // Print counter
                Console.WriteLine(counter2);

                // Plus one
                counter2++;

                // Continue looping while counter is less than 9 
            } while (counter2 < 9);
            Console.ReadLine();
        }
    }
}
