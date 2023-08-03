using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassInt myMethod = new MyClassInt();
            Console.WriteLine("Input a number you'd like to add");
            int userValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert a second optional number to add");
            int result;
            if (int.TryParse(Console.ReadLine(), out int userValue2))
            {
                result = myMethod.IntClass(userValue, userValue2);
            }
            else
            {
                result = myMethod.IntClass(userValue);
            }

            Console.WriteLine((result);
            Console.ReadLine();
            
        }
    }
}
