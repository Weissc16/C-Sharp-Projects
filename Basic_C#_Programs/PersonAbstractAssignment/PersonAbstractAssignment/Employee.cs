using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractAssignment
{
    public class Employee : Person, IQuittable
    {
        public static bool operator== (Employee employee, Employee employee2)
        {
            if (employee.id == employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.id != employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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