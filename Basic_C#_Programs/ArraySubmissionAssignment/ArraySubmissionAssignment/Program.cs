using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            string[] strArray = new string[] { "Hello", "Howdy", "Welcome", "Ahoy", "Hi" };

            Console.WriteLine("Pick a number, 0, 1, 2, 3, or 4, for a unique welcoming!");
            string selector = Console.ReadLine();
            int newSelect = Convert.ToInt32(selector);

            if (newSelect > 4)
            {
                Console.WriteLine("You selected a number that does not exist");
            }
            else
            {
                int[] numArray = new int[] { 1, 10, 100, 1000, 10000 };

                Console.WriteLine("Select a number 0 through 4 again for a unique number.");
                string num = Console.ReadLine();
                int userNum = Convert.ToInt32(num);

                if (userNum > 4)
                {
                    Console.WriteLine("You selected a number that does not exist");
                }
                else
                {
                    Console.WriteLine("Finally select 0 through 4 again for a unique motivational sentence.");
                    string motivate = Console.ReadLine();
                    int userMotive = Convert.ToInt32(motivate);

                    List<string> stringList = new List<string>();
                    stringList.Add("You're number one!");
                    stringList.Add("You're the best!");
                    stringList.Add("You da bomb!");
                    stringList.Add("You can do anything!");
                    stringList.Add("You have a bright future!");

                    if (userMotive > 4)
                    {
                        Console.WriteLine("You selected a number that does not exist");
                    }
                    else
                    {
                        Console.WriteLine("Your unique welcome is " + strArray[newSelect]);
                        Console.WriteLine("Your number is " + numArray[userNum]);
                        Console.WriteLine(stringList[userMotive]);
                    }
                }
            }



            
            Console.ReadLine(); 

        }
    }
}
