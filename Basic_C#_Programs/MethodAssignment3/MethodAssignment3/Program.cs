using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass newMethod = new myClass();

            newMethod.myMethod(x: 5, y: 7);
            Console.ReadLine();
        }
    }
}
