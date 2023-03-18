namespace TheLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();

            linkedList.AddFirst(101);
            linkedList.Print();
            linkedList.RemoveLast();
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(2);
            linkedList.Print();
            Console.WriteLine("Misho test");
            linkedList.RemoveAt(2); // misho test
            linkedList.Print();
            linkedList.AddLast(7);
            linkedList.AddLast(1);
            linkedList.Print();
            linkedList.AddFirst(101);
            linkedList.Print();
            linkedList.AddLast(79);
            linkedList.Print();
            Console.WriteLine("Sneji test");
            linkedList.RemoveFirst(); // snej test
            linkedList.Print();
            linkedList.AddLast(3);
            linkedList.AddLast(67);
            linkedList.Print();
            Console.WriteLine("georg test");
            linkedList.RemoveLast();// georg test
            linkedList.Print();
            linkedList.AddLast(4);

            linkedList.Print();
            linkedList.RemoveFirstFoundValue(7);
            linkedList.Print();
            linkedList.RemoveFirstFoundValue(9);
            linkedList.Print();
            linkedList.RemoveFirstFoundValue(4);
            linkedList.Print();

            linkedList.AddFirst(101);
            linkedList.Print();

            Console.WriteLine(linkedList.ElementAt(4));

            Console.ReadKey(true);
        }
    }
}