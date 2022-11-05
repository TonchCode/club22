using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolEquations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // !=  ==  >  <  <=  >=

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Enter your grade:");
            //double grade = Convert.ToDouble(    Console.ReadLine()     );
            //if (grade < 2 || grade > 6)
            //{
            //    Console.WriteLine("You just cant get that grade!!!!");
            //    Console.ReadKey();
            //    return;
            //}
            //if (grade < 3)
            //{
            //    Console.WriteLine($"Слаб ({grade})");
            //}
            //else if (grade < 3.5)
            //{
            //    Console.WriteLine($"Среден({grade})");
            //}
            //else if (grade > 3.5 && grade < 4.5)
            //{
            //    Console.WriteLine($"Добър({grade})");
            //}
            //else if (grade >= 4.5 && grade < 5.5)
            //{
            //    Console.WriteLine($"Много добър({grade})");
            //}
            //else
            //{
            //    Console.WriteLine($"Отличен({grade})");
            //} 
            ///////////////////////////////////////////////////////////////////////////////////////////
            

            double a, b, c;
            Console.Write("Enter first side:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second side:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third side:");
            c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Only positive values please!");
                Console.ReadKey(true);
                return;
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Triangle doesn't exist!");
                Console.ReadKey(true);
                return;
            }

            Console.WriteLine("Triangle exists");

            Console.ReadKey(true);
        }
    }
}
