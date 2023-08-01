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
            Console.WriteLine("Please Enter 6 new words");
            string[] array = new string[6];

            for (int i = 0; i < 6; i++)
            {
                array[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Press any key to print the words you input");
            Console.ReadLine();
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


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
            List<string> colorList = new List<string>() { "Red", "Blue", "Yellow", "Green", "Orange", "Black", "White", "Purple", "Pink", "Teal" };

            Console.WriteLine("Pick a Color (please capitalize your color)");
            string userColor = Console.ReadLine();
            int ind = colorList.IndexOf(userColor);

            for (int c = 0; c < colorList.Count; c++)
            {
                if (colorList.Contains(userColor))
                {
                    Console.WriteLine("Your Color " + userColor + " is in the list at index " + ind);
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
            int index = stringList.Item(flower);

            for (var f = 0; f < stringList.Count; f++)
            {
                if (stringList.Contains(flower))
                {
                    Console.WriteLine("We found your flower at index " + index + "and "+ index2);
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
