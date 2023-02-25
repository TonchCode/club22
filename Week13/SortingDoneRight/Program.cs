using System.Globalization;

namespace SortingDoneRight
{
    class Dog
    {
        private int age;
        private List<Dog> friends;
        private string name;

        public Dog(string name)
        {
            this.age = 0;
            this.name = name;
            this.friends = new List<Dog>();
        }

        public Dog(string name, List<Dog> friends)
        {
            this.age = 0;
            this.name = name;
            this.friends = friends;
        }

        public Dog(int age, string name)
        {
            this.age = age;
            this.name = name;
            this.friends = new List<Dog>();
        }
        public Dog(int age, string name, List<Dog> friends)
        {
            this.age = age;
            this.name = name;
            this.friends = friends;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public void YearPassed()
        {
            age++;
        }

        public void AddFriend(Dog dog)
        {
            friends.Add(dog);
        }

        public void ShowFriends()
        {
            Console.WriteLine(this.name + " has friends:");
            foreach (Dog fren in friends)
            {
                Console.Write("Name: " + fren.GetName() + " \tAge: " + fren.GetAge());
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class HomeDogs
    {
        List<Dog> dogs;

        public HomeDogs()
        {
            dogs = new List<Dog>();
        }

        public void OwnDog(Dog dog)
        {
            dogs.Add(dog);
        }

        public Dog Dog(int number)
        {
            return dogs[number-1];
        }

        public void YearPassed()
        {
            foreach (Dog dog in dogs)
            {
                dog.YearPassed();
            }
            Console.WriteLine("A Year has Passed");
            Console.WriteLine();
        }

        public void ShowDogs()
        {
            Console.WriteLine("Owned Dogs: ");
            foreach (Dog dog in dogs)
            {
                Console.Write("Name: " + dog.GetName() + " \tAge: " + dog.GetAge());
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        // static / readonly
        // public / private / protected / internal / private protected / protected internal
        // void / int / string / char / short / long / byte / double / decimal / float / Object 
        static void Main(string[] args)
        {
            HomeDogs Dogs = new HomeDogs();

            Dogs.OwnDog(new Dog("Jessie"));
            Dogs.OwnDog(new Dog(3, "Rex"));
            Dogs.OwnDog(new Dog(5, "Shiny", new List<Dog> { Dogs.Dog(1) }));

            Dogs.ShowDogs();

            Dogs.Dog(1).AddFriend(Dogs.Dog(2));

            Dogs.Dog(1).ChangeName("Sharo");

            Dogs.OwnDog(new Dog("Opal", new List<Dog> { Dogs.Dog(2), Dogs.Dog(3) }));

            Dogs.ShowDogs();

            Dogs.YearPassed();

            Dogs.ShowDogs();

            Dogs.Dog(4).ShowFriends();

            Console.ReadKey(true);
        }
    }
}