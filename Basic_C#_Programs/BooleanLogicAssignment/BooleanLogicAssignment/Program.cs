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
            Console.Write("What is your age? ");
            string age = Console.ReadLine();
            int newAge = Convert.ToInt32(age);

            Console.Write("Have you ever had a DUI? (please write true for yes and false for no) ");
            string dui = Console.ReadLine();
            bool newDui = Convert.ToBoolean(dui);

            Console.Write("How many speeding tickets do you have? ");
            string speedingTicket = Console.ReadLine();
            int ticketSpeeding = Convert.ToInt32(speedingTicket);

            bool qualified = newAge > 15 && newDui == false && ticketSpeeding <= 3;
            Console.WriteLine("Are you qualified?\n" + qualified);


            Console.ReadLine();
        }
    }
}
