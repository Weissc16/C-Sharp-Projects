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
            Console.WriteLine("What number would you like to use?");
           int userNum = Convert.ToInt32(Console.ReadLine());

            Multiply numOne = new Multiply();
            numOne.multiOne = 7;
            numOne.multiTwo = userNum;

            Console.WriteLine("7 times " + userNum + " equals: " + (numOne.multiOne * numOne.multiTwo));
            Console.ReadLine();

            
            Subtract numTwo = new Subtract();
            numTwo.subOne = 6;
            numTwo.subTwo = userNum;

            Console.WriteLine(userNum + "minus 6 equals: " + (numTwo.subTwo - numTwo.subOne));
            Console.ReadLine();

            Divide numThree = new Divide();
            numThree.divOne = 4;
            numThree.divTwo = userNum;

            Console.WriteLine( userNum + " divided by 4 equals: " + (numThree.divTwo / numThree.divOne));
            Console.ReadLine();

        }
    }
}
