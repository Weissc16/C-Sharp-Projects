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
        public int addition(decimal num2)
        {
            decimal v = num2 - 1;
            return Convert.ToInt32(v);            
        }

        public int addition(string num3)
        {
            string x = num3;
            int y = Convert.ToInt32(x);
            return y * 4;

        }
    }
}
