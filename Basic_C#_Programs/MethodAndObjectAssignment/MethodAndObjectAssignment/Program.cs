using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myObj = new Employee() { FirstName = "Sample ", LastName = "Student" };

            myObj.SayName();
            Console.ReadLine();
        }
    }
}
