namespace ArrToList
{
    internal class Program
    {
        static public List<int> AsList(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }
            return list;
        }

        static public int[] AsArray(List<int> list) 
        {
            int length = list.Count();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }

        static public void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static public void PrintArray(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static public void SortArray(int[] arr)
        {
            // Bubble Sort
            for (int i = 0; i < arr.Length - 1; i++) // Обхождаме масива без последният елемент за да не излизаме извън граници, заради {j = i + 1};
            {
                for (int j = i + 1; j < arr.Length; j++) // За всеки елемент (i) правим обход през всички останали елементи (j);
                {
                    if (arr[i] > arr[j]) // Сравняваме елемент (i) и (j) и ако (i) е по голям от който и да е от останалите елементи (j) разменяме стойностите им
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // static / readonly
            // public / private / protected / internal / private protected / protected internal
            // void / int / string / char / short / long / byte / double / decimal / float / Object

            int[] array = { 2, 5, 3, 8, 1 };

            List<int> list = AsList(array);

            PrintList(list);

            int[] array2 = AsArray(list);

            PrintArray(array2);

            int[] arr = AsArray(list);

            // Bubble Sort
            for (int i = 0; i < arr.Length - 1; i++) // Обхождаме масива без последният елемент за да не излизаме извън граници, заради {j = i + 1};
            {
                for (int j = i + 1; j < arr.Length; j++) // За всеки елемент (i) правим обход през всички останали елементи (j);
                {
                    if (arr[i] > arr[j]) // Сравняваме елемент (i) и (j) и ако (i) е по голям от който и да е от останалите елементи (j) разменяме стойностите им
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            SortArray(arr);
            
            PrintArray(arr);

            Console.ReadKey(true);
        }
    }
}