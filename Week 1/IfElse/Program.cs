using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine(x);
            Console.WriteLine(y);

            //int n = Convert.ToInt32(Console.ReadLine());
            ////n = int.Parse(Console.ReadLine());

            //if (n < 5)
            //{
            //    Console.WriteLine("Po malko ot 5");
            //}
            //else if (n == 5)
            //{
            //    Console.WriteLine("Ravno na 5");
            //}
            //else
            //{
            //    Console.WriteLine("Po golqmo ot 5");
            //}
            Console.ReadKey(true);
        }
    }
}
