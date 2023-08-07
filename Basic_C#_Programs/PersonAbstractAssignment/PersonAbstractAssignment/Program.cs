using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Stuff = new Employee<string>();
            Stuff.Things = new List<string>() { "Pencils", "Paper", "Notebooks", "ID", "Computer" };

            Employee<int> ID = new Employee<int>();
            ID.Things = new List<int>() { 12345, 12346, 12347, 12348, 12349 };

            foreach (string name in Stuff.Things) 
            {
                Console.WriteLine(name);
            }

            foreach (int num in ID.Things) 
            {
                Console.WriteLine(num);
            }

            Employee<string> employee = new Employee<string>() { firstName = "Sample ", lastName = "Student" };

            employee.SayName();
            Console.ReadLine();

            IQuittable Quittable = new Employee<string>();
            Quittable.Quit();
            

        }
    }
}
