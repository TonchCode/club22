using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10
{
    internal class Program
    {
        public static void method(DateTime timeOfDay)
        {

        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            for (int i = 0; i < 1500; i++)
            {
                Console.WriteLine(i);
            }
            DateTime end = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Time taken: ");
            Console.WriteLine((end - start).Seconds + "s:" + (end - start).Milliseconds + "ms");
            Console.WriteLine();
            Console.Write("Average time per element: ");
            Console.WriteLine(new TimeSpan((end - start).Ticks / 1500));

            string str1 = "\tHello \nWorld!";
            //Console.WriteLine(str1);
            Console.ReadKey(true);
        }
    }
}
