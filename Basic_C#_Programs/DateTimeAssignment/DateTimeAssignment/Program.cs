using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now + ": Please enter a number.");
            double number = Convert.ToDouble(Console.ReadLine());


            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            Console.WriteLine("It will be " + (dateTime.AddHours(number)) + " in " + number + " hours.");

            Console.ReadLine();

        }
    }
}
