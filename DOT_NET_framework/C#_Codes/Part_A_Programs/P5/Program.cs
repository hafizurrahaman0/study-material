using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables of main method
            int x = 40;
            int y = 60;
            // Local Function
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);

                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);

                Console.WriteLine("Sum: {0}", a + b + x + y);
                Console.ReadLine();
                Console.WriteLine();

            }
            // Calling Local function
            AddValue(50, 80);

            AddValue(79, 70);
            Console.ReadLine();
        }
    }
}
