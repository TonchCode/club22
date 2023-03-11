namespace TheLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();

            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(2);
            linkedList.AddLast(7);
            linkedList.AddLast(1);
            linkedList.AddLast(79);
            linkedList.AddLast(3);
            linkedList.AddLast(67);
            linkedList.AddLast(4);

            linkedList.Print();
            linkedList.RemoveValue(7);
            linkedList.Print();
            linkedList.RemoveValue(9);
            linkedList.Print();
            linkedList.RemoveValue(4);
            linkedList.Print();

            Console.WriteLine(linkedList.ElementAt(4));

            Console.ReadKey(true);
        }
    }
}