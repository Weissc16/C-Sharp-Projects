using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Cody";
            //string quote = "\"The man said\". \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("y");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Cody");

            string name = "Cody, ";
            string quote = "Hello there, ";
            string end = "it was nice to meet you";

            quote = quote.ToUpper();
            string sentence = quote + name + end;

            StringBuilder sb = new StringBuilder("Hello ");
            sb.Append("there! ");
            sb.AppendLine("What is your name?");
            sb.AppendLine("This is a new line using StringBuilder");
            sb.AppendLine("I can add an addition line as such.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
