using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write("It's coresponding sign is: ");
            if (input == 0)
            {
                Console.WriteLine(0);
            }
            else if (input < 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(1);
            }
            Console.ReadKey(true);
        }
    }
}
