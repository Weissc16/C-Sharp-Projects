using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Fname = "Bob", Lname = "Sparks", Id = 1},
                new Employee() { Fname = "Joe", Lname = "Dirt", Id = 2},
                new Employee() { Fname = "Cindy", Lname = "Cort", Id = 3},
                new Employee() { Fname = "Cody", Lname = "Weiss", Id = 4},
                new Employee() { Fname = "Joe", Lname = "Candelmo", Id = 5},
                new Employee() { Fname = "Tom", Lname = "Plessl", Id = 6},
                new Employee() { Fname = "Joe", Lname = "Schmo", Id = 7},
                new Employee() { Fname = "Dale", Lname = "Douglas", Id = 8},
                new Employee() { Fname = "Jess", Lname = "Winklespect", Id = 9},
                new Employee() { Fname = "Sarah", Lname = "Leboeuf", Id = 10},
            };
            List<Employee> newList = new List<Employee>();
            
            foreach (Employee name in employees)
            {
                if (name.Fname == "Joe")
                {
                    newList.Add(name);
                }
            }

            Console.WriteLine("For Each First Name of Joe");
            foreach (Employee name in newList)
            {
                
                Console.WriteLine(name.Fname + " " + name.Lname + " " + name.Id);
            }

            Console.WriteLine("\nLambda Joe's List");
            List<Employee> newList2 = employees.Where(x => x.Fname == "Joe").ToList();
            foreach (Employee name in newList2)
            {
                Console.WriteLine(name.Fname + " " + name.Lname + " " + name.Id);
            }

            Console.WriteLine("\nLambda ID greater than 5");
            List<Employee> newList3 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee name in newList3)
            {
                Console.WriteLine(name.Fname + " " + name.Lname + " " + name.Id);
            }
            Console.ReadLine();


                
        }
    }
}
