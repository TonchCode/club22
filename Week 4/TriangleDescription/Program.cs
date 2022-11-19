using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDescription
{
    internal class Program
    {
        static void Main(string[] args)
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
                return;
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Не е триъгълник!");
                return;
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

            Console.ReadKey(true);
        }
    }
}
