using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 5;
            int add = num1 + num2;
            Console.WriteLine(add);
            int sub = num1 - num2;
            Console.WriteLine(sub);
            int mult = num1 * num2;
            Console.WriteLine(mult);
            int div = num2 / num1;
            Console.WriteLine(div);

            string fname = "Cody";
            string lname = "Weiss";
            Console.WriteLine(fname + " " + lname);
            Console.ReadLine();
        }
    }
}
