using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    internal class Program
    {
        // number 5
        // result 25
        static int Pow(int number, int power)
        {
            int result = number;
            for (int i = 1; i < power; i++)
            {
                result = result * number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("C# method: " + Math.Pow(100, 4));

            Console.WriteLine("Our method: " + Pow(100, 4));

            Console.ReadKey(true);
        }
    }
}
