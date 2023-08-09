using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            string number = string.Format(Console.ReadLine());

            Console.WriteLine("You chose the number " + number);
            using (StreamWriter file = new StreamWriter(@"C:\Users\weiss\Logs\log.txt", true))
            {
                file.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
