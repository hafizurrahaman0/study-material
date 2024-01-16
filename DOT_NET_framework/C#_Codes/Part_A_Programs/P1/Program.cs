using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a, b;
            Console.WriteLine("Enter any two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Simple if statement");
            Console.WriteLine("2. if else statement");
            Console.WriteLine("3. else if statement");
            Console.WriteLine("4. Exit");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    if (a < b)
                    {
                        Console.WriteLine("a is smallest");
                    }
                    break;
                case 2:
                    if (a > b)
                        Console.WriteLine("a is largest");
                    else
                        Console.WriteLine("b is largest");
                    break;
                case 3:
                    if (a == b)
                        Console.WriteLine("a is equal to b");
                    else if (a > b)
                        Console.WriteLine("a greater than b");
                    else
                        Console.WriteLine("b greater than a");
                    break;
                case 4:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
