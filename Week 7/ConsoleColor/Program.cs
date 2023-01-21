using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < size - 4; i++)
            for (int i = 0; i < size - (int)(4 / 9.0 * size); i++)
            {
                for (int l = size; l >= i; l--)
                {
                    Console.ResetColor();
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    int g = i + j;
                    if (g % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = (int)(3/9.0 * size); i < size - (int)(2 / 9.0 * size); i++)
            //for (int i = 3; i < size - 2; i++)
            {
                for (int l = size; l >= i; l--)
                {
                    Console.ResetColor();
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    int g = i + j;
                    if (g % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = (int)(5/9.0 * size); i < size; i++)
            //for (int i = 5; i < size; i++)
            {
                for (int l = size; l >= i; l--)
                {
                    Console.ResetColor();
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    int g = i + j;
                    if (g % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.BackgroundColor = ConsoleColor.Magenta;
            //            Console.ForegroundColor = ConsoleColor.Cyan;

            //            Console.Write(" & ");
            //        }
            //        else
            //        {
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Blue;

            //            Console.Write(" % ");
            //        }
            //    } 
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
