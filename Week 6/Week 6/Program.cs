using System;

namespace Week_6
{
    internal class Program
    {
        // public, private, protected, internal <- access modifiers // static
        //class Dog
        //{
        //    public int age = 10;
        //    public void PrintAge()
        //    {
        //        Console.WriteLine(age);
        //    }
        //    public void SetAge(int age)
        //    {
        //        this.age = age;
        //    }
        //}

        static int sum(int a, int b)
        {
            return a + b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
        static int div(int a, int b)
        {
            return a / b;
        }
        static int mult(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            //Dog Carl = new Dog();
            //Dog Jackson = new Dog();

            //Carl.PrintAge();
            //Jackson.SetAge(20);
            //Jackson.PrintAge();

            //Dog.PrintAge();

            //Console.WriteLine("Hello World!");
            //Console.Write("asd");
            //string a = Console.ReadLine();

            // 0 - exit
            // 1 - sum
            // 2 - sub
            // 3 - mult
            // 4 - div

            while (true)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("Exit - 0");
                Console.WriteLine("Sum - 1");
                Console.WriteLine("Substract - 2");
                Console.WriteLine("Multiply - 3");
                Console.WriteLine("Divide - 4");
                Console.Write("> ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0: 
                        Console.WriteLine("Exiting: Press any key to continue...");
                        Console.ReadKey(true);
                        return;
                    case 1:
                        Console.Write("Enter a: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter b: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sum of a and b is: " + sum(a, b));
                        break;
                    case 2:
                        Console.Write("Enter a: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter b: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Result of a - b is: " + sub(x, y));
                        break;
                    case 3:
                        Console.Write("Enter a: ");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter b: ");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Result of a * b is: " + mult(i, j));
                        break;
                    case 4:
                        Console.Write("Enter a: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter b: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        if (m == 0)
                        {
                            Console.WriteLine("Can't divide by 0");
                            break;
                        }
                        Console.WriteLine("Result of a / b is: " + div(n, m));
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
