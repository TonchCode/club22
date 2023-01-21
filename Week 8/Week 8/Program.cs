using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a size for the sideways pyramid: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int change = 1;
            //for (int i = 1; i > 0; i += change)
            //{
            //    if (i >= n)
            //    {
            //        change = -1;
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" #");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" #");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n - 1; i > 0; i--)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        Console.Write(" #");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("///////////////////////That was sideways pyramid/////////////////////");
            //Console.ReadKey();
            //Console.Clear();

            //int a = Convert.ToInt32(Console.ReadLine());



            //Random random = new Random();
            //int size = random.Next(1, 11);
            //int[] array = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = random.Next(1, 51);
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write(array[i] + ", ");
            //}

            ////////////////////////////////////////////////////////////////////////

            //Random random = new Random();
            //const int size = 6;
            //int[] randomarr = new int[size];
            //int[] userarr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    randomarr[i] = random.Next(1, 19);
            //}
            //Console.WriteLine("\t\tLOTTERY 6 from 18");
            //Console.WriteLine("Enter 6 numbers from 1 to 18");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Num #"+(i+1)+": ");
            //    userarr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int hits = 0;
            //Console.WriteLine("CPU\t : User");
            //for (int i = 0; i < size; i++)
            //{
            //    if (userarr[i] == randomarr[i])
            //    {
            //        hits++;
            //    }
            //    Console.WriteLine(randomarr[i] + "\t : " + userarr[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("You got " + hits + " right answers!");
            //if (hits == size)
            //{
            //    Console.WriteLine("\t\t!!!Congratz, you won!!!");
            //}
            //Console.ReadKey();


            /////////////////////////////////////////////////////////////////////////////////////////
            ///

            Random randomacc = new Random();
            int money = randomacc.Next(5, 11);
            for (int q = 0; q < 3; q++)
            {
                Console.WriteLine("       LOТTERY 6 ТО 18       ");
                Console.WriteLine("============================");
                Console.WriteLine("");
                Console.WriteLine("If you can save you'r monny ");
                Console.WriteLine("in 3 rounds you'll win, but");
                Console.WriteLine("if you spend all of the monny");
                Console.WriteLine("you'll lose.");
                Console.WriteLine("");
                Console.WriteLine("One mached numbers = 10$");
                Console.WriteLine("Two mached numbers = 20$");
                Console.WriteLine("Three mached numbers = 50$");
                Console.WriteLine("Zero mached numbers = - 5$");
                Console.WriteLine("To play you need atleast 5$");
                Console.WriteLine("");

                Console.WriteLine("You have: " + money);

                Console.WriteLine("");
                Console.WriteLine("Enter 6 numbers from 1 to 18");
                Console.WriteLine("");
                Console.WriteLine("============================");
                Console.WriteLine("");

                int[] AInumbs = new int[6];

                for (int i = 0; i < 6; i++)
                {
                    AInumbs[i] = Convert.ToInt32(Console.ReadLine());
                    if (AInumbs[i] > 18 || AInumbs[i] < 1)
                    {
                        Console.WriteLine("The number has to be between 1 an 18");
                        Console.ReadKey(true);
                        return;
                    }
                }

                Console.WriteLine("============================");
                Console.WriteLine("AI nubers:     YOUR numbers:");
                Console.WriteLine("");

                int[] Mynumbs = new int[6];
                Random random = new Random();

                for (int i = 0; i < 6; i++)
                {
                    Mynumbs[i] = random.Next(1, 19);
                }

                for (int i = 0; i < 6; i++)
                {
                     Console.WriteLine(Mynumbs[i] + "\t     |             " + AInumbs[i]);
                }

                Console.WriteLine("");
                Console.WriteLine("============================");
                Console.WriteLine("");

                int a = 0;

                for (int i = 0; i < 6; i++)
                {
                    if (AInumbs[i] == Mynumbs[i])
                    {
                        a = a + 1;
                        money += a * 10;
                    }
                }
                if (a == 0)
                {
                    money -= 5;
                }

                Console.WriteLine("Maching numbers: " + a);

                if (money < 0)
                {
                    Console.WriteLine("You feal, now you own monny to the Lottery");
                    Console.ReadKey(true);
                    return;
                }
                else if (money < 5 && money >= 0)
                {
                    Console.WriteLine("You have: " + money);
                    Console.WriteLine("You don't have enough monny to play.");
                    Console.ReadKey(true);
                    return;
                }
                else
                {
                    Console.WriteLine("You have left: " + money);
                    Console.WriteLine("");
                    Console.ReadKey(true);
                }
                Console.Clear();
            }
        }
    }
}
