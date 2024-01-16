using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace loopingstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int i;
            int a = 1;
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. For loop");
            Console.WriteLine("2. While loop");
            Console.WriteLine("3. Do loop");
            Console.WriteLine("4. For each loop");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:

                    Console.WriteLine("First 10 Natural Numbers are: ");
                    for (i = 1; i <= 10; i++)
                        Console.WriteLine(i);
                    break;
                case 2:
                    while (a <= 10)
                    {
                        Console.WriteLine(a);
                        a++;
                    }
                    break;
                case 3:
                    do
                    {
                        Console.WriteLine(a);
                        a++;
                    }
                    while (a <= 10);
                    break;
                case 4:
                    char[] myArray = { 'H', 'e', 'l', 'l', 'o' };
                    foreach (char ch in myArray)
                    {
                        Console.WriteLine(ch);
                    }
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
