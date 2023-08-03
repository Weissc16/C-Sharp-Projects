using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod myMethod = new MathMethod();

            Console.WriteLine("Input a number you would like to do some math operations on");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myMethod.mathMethod1(userNum));
            Console.WriteLine(myMethod.mathMethod2(userNum));
            Console.WriteLine(myMethod.mathMethod3(userNum));

            Console.ReadLine();

        }
    }
}
