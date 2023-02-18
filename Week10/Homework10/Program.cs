using System.Globalization;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you'r birthdate [day/month/year] : ");
            DateTime start = Convert.ToDateTime(Console.ReadLine());
            DateTime end = DateTime.Now;
            Console.WriteLine();
            Console.Write("Days lived: ");
            Console.WriteLine((end - start).Days + " days");
            Console.ReadKey(true);
        }
    }
}