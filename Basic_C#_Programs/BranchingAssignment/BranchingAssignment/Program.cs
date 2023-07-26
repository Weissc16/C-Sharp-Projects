using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");

            Console.Write("What is the weight of your package in lbs? ");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.Write("Package too heavy to be shipped via Package Express.  Have a good day!");
            }
            else
            {
                Console.Write("What is the width of your package in inches? ");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is the length of your package in inches? ");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is the height of your package in inches? ");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                if ((packageWidth + packageLength + packageHeight) > 50)
                {
                    Console.Write("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double quote = ((packageHeight * packageLength * packageWidth) * packageWeight) / 100.00;
                    Console.WriteLine("Your quote for this package is:  $ " + quote);
                }

            }
            Console.ReadLine();
        }
    }
}
