using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine("I'm thinking of a number from 1 to 10, can you guess it?");
            int number = Convert.ToInt32(Console.ReadLine());

            bool numGuessed = number == 7;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You got it! The number was 7!");
                        numGuessed = true;
                        break;
                    case 8:
                        Console.WriteLine("You guessed 1.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10.  Sorry, try again");
                        Console.WriteLine("Guess another number..");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!numGuessed);

            Console.ReadLine();
        }
    }
}
