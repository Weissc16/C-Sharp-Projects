using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class myClass
    {
        public int addition(int num)
        {
            return num + 5;
        }
        public decimal subtraction(decimal num2)
        {
            decimal v = num2 - 1;
            return Convert.ToInt32(v);            
        }

        public int multiplication(string num3)
        {
            string x = num3;
            int y = Convert.ToInt32(x);
            return y * 4;

        }
    }
}
