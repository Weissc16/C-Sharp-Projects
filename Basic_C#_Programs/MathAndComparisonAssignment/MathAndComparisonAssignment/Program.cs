using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.Write("What is your hourly rate? ");
            string hourlyRate = Console.ReadLine();
            double rateHourly = Convert.ToDouble(hourlyRate);
            Console.Write("How many hours do you work per week? ");
            string weeklyHours = Console.ReadLine();
            int hoursWeekly = Convert.ToInt32(weeklyHours);
            Console.WriteLine("Person 2");
            Console.Write("What is your hourly rate? ");
            string hourlyRate2 = Console.ReadLine();
            double rateHourly2 = Convert.ToDouble(hourlyRate2);
            Console.Write("How many hours do you work per week? ");
            string weeklyHours2 = Console.ReadLine();
            int hoursWeekly2 = Convert.ToInt32(weeklyHours2);

            double Person1Salary = (rateHourly * hoursWeekly) * 52;
            double Person2Salary = (rateHourly2 * hoursWeekly2) * 52;
            Console.WriteLine("The Annual Salary of Person 1 is: " + Person1Salary);
            Console.WriteLine("The Annual Salary of Person 2 is: " + Person2Salary);

            bool comparison = Person1Salary > Person2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + comparison);

            Console.Read();
        }
    }
}
