using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractAssignment
{
    public class Employee<T> : Person, IQuittable
    {
        public List<T> Things { get; set; }


        public static bool operator== (Employee<T> employee, Employee<T> employee2)
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
        public static bool operator!= (Employee<T> employee, Employee<T> employee2)
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