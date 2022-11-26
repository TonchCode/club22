using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "qwerty";
            //char[] ab = { 'q', 'w', 'e', 'r', 't', 'y' };
            //foreach(char symb in str)
            //{
            //    Console.WriteLine(symb);
            //}

            //Console.Write("Enter a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //while (true)
            //{
            //    Console.WriteLine(b++);
            //    if (b == a)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);


            // Enter number: 10256
            // Evens: 3

            //int b = 0123045;

            //b = b / 10; // 12304
            //b = b / 10; // 1230
            //b = b / 10; // 123
            //b = b / 10; // 12
            //b = b / 10; // 1
            //b = b / 10; // 0

            //bool d = b % 10 % 2 == 0; // false


            //Console.Write("Enter number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while(n != 0)// (true)
            //{
            //    if (n % 10 % 2 == 0)
            //    {
            //        count++;
            //    }

            //    n /= 10; // n = n / 10;

            //    //if (n == 0)
            //    //{
            //    //    break;
            //    //}
            //}
            //Console.WriteLine("Evens: " + count);

            //for(int i = n; i != 0; i /= 10)
            //{
            //    if (i % 10 % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Evens: " + count);

            //do
            //{
            //    if (n % 10 % 2 == 0)
            //    {
            //        count++;
            //    }

            //    n /= 10; // n = n / 10

            //} while (n != 0);
            //Console.WriteLine("Evens: " + count);

            //Console.Write("Enter starting number: ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter ending number: ");
            //int end = Convert.ToInt32(Console.ReadLine());

            //if (start > end)
            //{
            //    while (start != end - 1)
            //    {
            //        Console.Write(start-- + " ");
            //    }
            //}
            //else
            //{
            //    while (start != end + 1)
            //    {
            //        Console.Write(start++ + " ");
            //    }
            //}

            // pravougulnik
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("* * * * * * *");
            }
            Console.WriteLine();

            //triugulnik
            for(int i = 1; i <= 6; i++) // redove
            {
                for (int j = 1; j <= i; j++) // simvoli na vseki red
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //obraten triugulnik s razmer
            Console.Write("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = size; i >= 1; i--) // redove
            {
                for (int j = 1; j <= i; j++) // simvoli na vseki red
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //piramida
            Console.Write("Enter pyramid size: ");
            int pyrm = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= pyrm; i++) // redove
            {
                for (int j = 1; j <= pyrm-i; j++) // simvoli na vseki red
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
