using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What number should we times by 50? ");
            string favNumber = Console.ReadLine();
            int numberFav = Convert.ToInt32(favNumber);
            Console.WriteLine("Your number times 50 is " + numberFav * 50);

            Console.Write("What number would you like to add 25 to? ");
            string addNumber = Console.ReadLine();
            int numberAdd = Convert.ToInt32(addNumber);
            Console.WriteLine("Your number plus 25 is " + (numberAdd + 25));

            Console.Write("Lets divide a number by 12.5, what number would you like to use? ");
            string divNumber = Console.ReadLine();
            double numberDiv = Convert.ToDouble(divNumber);
            Console.WriteLine("Your number divided by 12.5 is " + (numberDiv / 12.5));
            

            Console.Write("Now lets compare a number and see if it is greater than 50.  What number would you like to compare? (false is less than 50, true is greater than) ");
            string compNumber = Console.ReadLine();
            int numberComp = Convert.ToInt32(compNumber);
            bool Comparison = numberComp > 50;
            Console.WriteLine(Comparison);
            

            Console.Write("Finally, lets divide a number by 7 and get the remainder.  What number would you like to use? ");
            string modNumber = Console.ReadLine();
            int numberMod = Convert.ToInt32(modNumber);
            Console.WriteLine("The remainder is: " + (numberMod % 7));
            Console.ReadLine();
        }
    }
}
