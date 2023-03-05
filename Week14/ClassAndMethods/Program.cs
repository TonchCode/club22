using System.Reflection.Metadata;

namespace ClassAndMethods
{
    class Cat
    {
        int age;
        string name;
        string breed;
        public static bool IsDay;

        public Cat(int age, string name, string breed)
        {
            this.age = age;
            this.name = name;
            this.breed = breed;
        }

        public string GetName()
        {
            return name;
        }

        public void Sleep()
        {
            if (IsDay == false)
            {
                Console.WriteLine("I sleep");
                return;
            }
            Console.WriteLine("I don't sleep");
        }
    }

    class User
    {

    }

    static class Facebook
    {
        static List<User> users = new List<User>();
        //static neshtoKatoList<User> friendList

        public void InfoFor(User user)
        {
            bool exists = false;
            foreach (User item in users)
            {
                if (item == user)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                user.ShowAllInfo();
            }
            else
            {
                Console.WriteLine("Such Person Does Not Exist");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //  static / readonly
            // Protection Levels: public / private / protected / internal / private protected / protected internal
            // Value Types: void / int / string / char / short / long / byte / double / decimal / float / Object 

            Cat Kotka1 = new Cat(3, "Bat Nasko", "ulichna");
            Cat Kotka2 = new Cat(5, "Hello", "ulichna");
            Cat Kotka3 = new Cat(1, "Kat", "ulichna");
            Cat Kotka4 = new Cat(0, "Pombi", "ulichna");
            //Console.WriteLine(Kotka1.GetName());
            //Console.WriteLine(Kotka3.GetName());
            //Console.WriteLine();
            //Kotka2.Sleep();
            //Kotka3.Sleep();
            //Kotka4.Sleep();
            //Cat.IsDay = true;
            //Kotka2.Sleep();
            //Kotka3.Sleep();
            //Kotka4.Sleep();

            List<Cat> cats = new List<Cat>();
            cats.Add(Kotka1);
            cats.Add(new Cat(6, "zdrasti", "kusokosmesta"));

            cats[1].Sleep();


            LinkedList<Cat> list = new LinkedList<Cat>();
            list.AddFirst(Kotka1);
            list.AddLast(Kotka2);
            list.AddLast(Kotka3);
            list.AddLast(Kotka4);
            list.AddFirst(new Cat(6, "zdrasti", "kusokosmesta"));

            //list.First().Next().Next().Sleep();

            //           key  value
            //Dictionary<int, int> 


            // Domashna next time:
            // broi dumi v text
            string str = "Hello World!";
            string[] strs = str.Split('l', 'o');
            foreach (string item in strs)
            {
                Console.Write(item);
            }

            // izpisvane na masiv bez cikul
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}