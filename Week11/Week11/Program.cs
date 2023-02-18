namespace Week11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();

            while (true)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp == -1)
                {
                    break;
                }
                if (temp < 1)
                {
                    continue;
                }
                years.Add(temp);
                foreach (int year in years)
                {
                    Console.Write(year + ", ");
                }
            }

            int min = years.Min();
            Console.WriteLine("The person born in {0} is the oldest!", min);

            Console.ReadKey();
            years.Add(1);
            years.Add(4);
            years.Add(100);
            years.Add(5);
            years.Add(2);
            years.Add(10);

            years.RemoveAt(4);

            foreach (int chislo in years)
            {
                Console.Write(chislo + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < years.Count(); i++)
            {
                Console.Write(years[i] + ", ");
            }

            Console.ReadKey(true);
        }
    }
}
