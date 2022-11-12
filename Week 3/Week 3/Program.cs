using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)
            // (bool ? true : false)
            // if          else

            //Console.WriteLine("Enter day, month, year: ");
            //int d, m, y;
            //d = Convert.ToInt32(Console.ReadLine());
            //m = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());
            //bool vis = ((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0);
            //int dayCount = 0;

            //if (m > 1)
            //{
            //    dayCount += 31;
            //}
            //if (m > 2)
            //{
            //    dayCount += 28 + (vis ? 1 : 0);
            //}
            //if (m > 3)
            //{
            //    dayCount += 31;
            //}
            //if (m > 4)
            //{
            //    dayCount += 30;
            //}
            //if (m > 5)
            //{
            //    dayCount += 31;
            //}
            //if (m > 6)
            //{
            //    dayCount += 30;
            //}
            //if (m > 7)
            //{
            //    dayCount += 31;
            //}
            //if (m > 8)
            //{
            //    dayCount += 31;
            //}
            //if (m > 9)
            //{
            //    dayCount += 30;
            //}
            //if (m > 10)
            //{
            //    dayCount += 31;
            //}
            //if (m > 11)
            //{
            //    dayCount += 30;
            //}

            //Console.WriteLine(dayCount + d);

            ///////////////////////////////////////////// ALGORITHM /////////////////////////////////////////////////

            //Console.WriteLine("Put a date :");
            //int dateY = int.Parse(Console.ReadLine());
            //int dateM = int.Parse(Console.ReadLine());
            //int dateD = int.Parse(Console.ReadLine());

            //int daysFromMonths = (dateM - 1) * 30 + ((dateM) / 2);

            //if (dateM >= 2)
            //{
            //    daysFromMonths -= 2;

            //    if ((dateY % 4 == 0 && dateY % 100 != 0) || dateY % 400 == 0)
            //    {
            //        daysFromMonths++;
            //    }
            //}

            //int days = dateD + daysFromMonths + (dateM > 8 ? 1 : 0);

            //Console.WriteLine($"{days} days have passed");

            Console.ReadKey(true);
        }
    }
}
