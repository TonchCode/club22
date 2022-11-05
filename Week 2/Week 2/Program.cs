using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double temp = 0;
            //
            if (c < a)
            {
                temp = c;
                c = a;
                a = temp;
            }
            
            if (c < b)
            {
                temp = c;
                c = b;
                b = temp;
            }

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            //
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey(true);
        }
    }
}
