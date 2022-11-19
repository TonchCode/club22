using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Брояч  for (<param>; <bool>; <exec>)
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // while (<bool>)
            //Console.Write("Enter n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //while(n <= 0)
            //{
            //    Console.Write("Enter n (must be positive): ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //}

            // do while (<bool>)
            //int n = -10;
            //do
            //{
            //    Console.WriteLine(n * 26);
            //} while (n >= 0);

            // foreach ()
            //{ 1, 2, 3, 4}

            while (true)
            {
                Console.Write("Enter side a: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter side b: ");
                double b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter side c: ");
                double c = Convert.ToInt32(Console.ReadLine());

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Невъзможен триъгълник!");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }

                if (a + b < c || a + c < b || b + c < a)
                {
                    Console.WriteLine("Не е триъгълник!");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }

                if (a != b && b != c && c != a)
                {
                    Console.WriteLine("Разностранен");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("Равностранен");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine("Равнобедрен");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
            }

            Console.WriteLine("Program will close!");
            Console.ReadKey(true);
        }
    }
}
