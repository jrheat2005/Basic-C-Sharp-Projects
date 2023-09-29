using System;
using System.Text;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello my name is ";
            string str2 = "Joshua ";
            string str3 = "Heaton.";
            Console.WriteLine(str1 + str2 + str3);
            

            string name = "John Doe";
            string upper = name.ToUpper();
            Console.WriteLine(upper);

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("My name is ");
            paragraph.Append(upper);

            paragraph.Append(". I am learning C#.");

            string result = paragraph.ToString();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
