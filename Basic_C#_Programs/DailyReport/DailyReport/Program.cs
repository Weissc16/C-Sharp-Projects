using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Thank you, " + yourName + "!");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine(courseName + " is a fun course!");
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Wow, already " + pageNumber + " pages in, keep up the good work!");
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string needHelp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(needHelp);
            Console.WriteLine("Thank you for your answer, an instrctor will respond to this shortly");
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Thank you for that response!");
            Console.WriteLine("How many hours did you study today?");
            string hourStudy = Console.ReadLine();
            Console.WriteLine("Great job studying " + hourStudy + " hours today! Keep up the great work!");



            Console.ReadLine();
        }
    }
}
