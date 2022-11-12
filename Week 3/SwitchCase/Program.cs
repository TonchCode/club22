using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            // 4321
            // т0т0
            // 2451
            // * + - / %

            //321
            //039 = 9
            //008 = 0
            //040 = 0

            //8
            //40
            //39

            Console.WriteLine(number /= 10);

            if ((number % 10) % 2 == 0)
            {
                Console.WriteLine("second position is even");
            }
            else
            {
                Console.WriteLine("second position is odd");
            }

            Console.WriteLine(number /= 10);
            Console.WriteLine(number /= 10);

            if ((number % 10) % 2 == 0)
            {
                Console.WriteLine("fourth position is even");
            }
            else
            {
                Console.WriteLine("fourth position is odd");
            }

            Console.ReadKey(true);
        }
    }
}
