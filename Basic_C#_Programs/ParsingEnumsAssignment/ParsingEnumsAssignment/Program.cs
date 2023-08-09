using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParsingEnumsAssignment.Days;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is the current day of the week?");
                string dayUser = Console.ReadLine();

                //Days day = Enum.Parse(Days.DaysOfTheWeek);
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayUser);


                Console.WriteLine(day);
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();




          

        }
    }
}
