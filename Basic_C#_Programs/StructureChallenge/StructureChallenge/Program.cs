using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           Number num = new Number();
           num.Amount = (decimal)17.56;

            Console.WriteLine(num.Amount);
            Console.ReadLine();

        }
    }
}
