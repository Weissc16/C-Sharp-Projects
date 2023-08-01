using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What number should we use to divide by?");
                int divideNum = Convert.ToInt32(Console.ReadLine());

                List<int> divideList = new List<int>();
                divideList.Add(10);
                divideList.Add(17);
                divideList.Add(29);
                divideList.Add(34);
                divideList.Add(42);

                foreach (int num in divideList)
                {
                    Console.WriteLine(num + " divided by " + divideNum + " equals: " + num / divideNum);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("This has been done through a Try/Catch block");
            Console.ReadLine();
        }
    }
}
