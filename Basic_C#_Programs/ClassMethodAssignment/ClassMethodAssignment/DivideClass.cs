using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class DivideClass
    {
        public void DivideNum(int num)
        {
            int x = num / 2;
            Console.WriteLine(x);
        }

        public static void DivideNum(out int number, string divide)
        {

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number + divide);
        }

        
        
    }
}
