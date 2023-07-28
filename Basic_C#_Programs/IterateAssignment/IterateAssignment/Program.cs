using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pt 1 steps 1-4
            string[] userArray = { "My favorite number is ", "My age is ", "Miles I ran today is " };

            Console.WriteLine("What is your favorite number?");
            string num = Console.ReadLine();

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine(userArray[i] + num);
            }

            Console.ReadLine();

            //infinite loop without using "break;"  fixed by adding "break;" Pt 2 steps 1-4
            while (true)
            {
                Console.WriteLine("This is no longer infinite");
                break;
            }

            Console.ReadLine();


            //pt 3. steps 1-4
            int[] testScores = { 95, 90, 88, 72, 95, 90, 67, 75, 62, 50 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] < 80)
                {
                    Console.WriteLine("Scores less than 80%: " + testScores[i]);
                }
            }

            Console.ReadLine();

            int[] Scores = { 95, 90, 88, 72, 95, 90, 67, 75, 62, 50 };

            for (int x = 0; x < Scores.Length; x++)
            {
                if (Scores[x] <= 75)
                {
                    Console.WriteLine("Scores less than or equal to 75%: " + Scores[x]);
                }
            }
            Console.ReadLine();


            //loop that tells if the input the user input is in the string or not. Pt. 4 step #1 thru 5
            string[] colors = { "Red", "Blue", "Yellow", "Green", "Orange", "Black", "White", "Purple", "Pink", "Teal" };

            Console.WriteLine("Pick a Color (please capitalize your color)");
            string userColor = Console.ReadLine();

            for (int c = 0; c < colors.Length; c++)
            {
                if (colors.Contains(userColor))
                {
                    Console.WriteLine("Your Color " + userColor + " is in the list");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, your color " + userColor + " is not in the list.");
                    break;
                }
            }

            Console.ReadLine();


            //Pt 5 step 1-4
            List<string> stringList = new List<string>();
            stringList.Add("rose");
            stringList.Add("violet");
            stringList.Add("daisy");
            stringList.Add("rose");
            stringList.Add("lilly");


            Console.WriteLine("What type of flower do you like?");
            string flower = Console.ReadLine();
            int index = stringList.FindIndex(a => a.Contains(flower));

            for (var f = 0; f < stringList.Count; f++)
            {
                if (stringList.Contains(flower))
                {
                    Console.WriteLine("We found your flower at index " + index);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry we do not have your flower type");
                    break;
                }
            }
            Console.ReadLine();


            //Pt 6 step 1-4
            List<string> sportsList = new List<string>() { "Baseball", "Basketball", "Football", "Soccer", "Baseball" };
            IEnumerable<string> result = sportsList.Distinct();

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

    }
}
