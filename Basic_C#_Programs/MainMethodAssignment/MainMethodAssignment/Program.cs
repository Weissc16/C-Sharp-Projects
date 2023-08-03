using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass newMethod = new myClass();

            Console.WriteLine(newMethod.addition(5));
            Console.ReadLine();

            myClass subMethod = new myClass();

            Console.WriteLine(subMethod.subtraction((decimal)2.31111323));
            Console.ReadLine();

            myClass multMethod = new myClass();

            Console.WriteLine(multMethod.multiplication("3"));
            Console.ReadLine();
        }
    }
}
