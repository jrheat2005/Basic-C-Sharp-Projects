using System;

namespace DR_For_TTA
{
    class Program
    {
        static void Main(string[] args)
        {
            //print header
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            // get name
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            // get course number
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            
            //get page number
            Console.WriteLine("What page number?");
            ushort pageNum = ushort.Parse(Console.ReadLine());

            // check if help is needed
            Console.WriteLine("Do you need help with anything? Please anwser \"true\" or \"false\".");
            bool needHelp = Console.ReadLine() == "true";

            // get positive feedback
            Console.Write("\nWere there any positive experiences you’d like to share? Please give specifics. ");
            string positiveExp = Console.ReadLine();

            // get feedback
            Console.Write("\nIs there any other feedback you’d like to provide? Please be specific. ");
            string otherFeedback = Console.ReadLine();

            // get hours studied
            Console.Write("\nHow many hours did you study today? ");
            double hoursStudied = double.Parse(Console.ReadLine());

            // print closing message
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
