using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////if, else if and else statements/////////
            //string name = "Cody";

            //if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is Brett");
            //}
            //else if (name == "John")
            //{
            //    Console.WriteLine("Your name is John");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not Brett or John.");
            //}

            /////////Using != symbol////////////
            //string name = "John";

            //if (name != "Cody")
            //{
            //    Console.WriteLine("Who are you? You're not Cody");
            //}
            //else
            //{
            //    Console.WriteLine("Hi Cody!");
            //}

            /////////Lesser than operators//////////
            //int age = 20;

            //if (age < 21)
            //{
            //    Console.WriteLine("No you may not purchase alcohol");
            //}
            //else
            //{
            //    Console.WriteLine("You are of the age to purchase alcohol");
            //}

            //////////Greater than operator///////////
            //int age = 18;

            //if (age > 17)
            //{
            //    Console.WriteLine("You may rent a car");
            //}
            //else
            //{
            //    Console.WriteLine("You are too young to rent a car");
            //}

            ////// OR and AND operators///////
            //int num1 = 7;
            //if (num1 < 18 && ((num1 == 7) || num1 == 2) && ((num1 == 8 && num1 > 20) || (num1 < 20 && num1 > 2)))
            //{
            //    Console.WriteLine("Wow, that was confusing.");
            //}

            //////Ternary Operator////////
            //int num1 = 7;
            //int num2 = 10;

            //string result = num1 > num2 ? "The first option was used" : "The second option was used";
            //Console.WriteLine(result);

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temp is warmer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}


            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly Room Temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temp");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("it is colder than room temp.");
            //}    
            //else
            //{
            //    Console.WriteLine("something went wrong");
            //}

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "you have an awesome favorite number" : "you do not have an awesome favorite number";

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
