using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you would like divided by 2:");
            int x = Convert.ToInt32(Console.ReadLine());

            DivideClass userNum = new DivideClass();

            userNum.DivideNum(x);
            Console.ReadLine();

            Console.WriteLine("Enter another number.");

            DivideClass userNum2 = new DivideClass();


            DivideClass.DivideNum(out int number, " is a great number");
            Console.ReadLine();

            MyStaticClass.MyStaticMethod();
            Console.ReadLine();

        }
    }
}
