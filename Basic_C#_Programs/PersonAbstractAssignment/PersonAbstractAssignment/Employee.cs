using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name " + firstName + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}
s