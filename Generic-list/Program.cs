using CustomList;
using System.ComponentModel;
    public class Program
    {
        public static void Main()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine("All items:");
            foreach (var item in list.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Contains 2: " + list.Contains(2));

            Console.WriteLine("First item: " + list.GetFirst());
            Console.WriteLine("Element 1: " + list.GetElementAt(1));
            Console.WriteLine("Last item: " + list.GetLast());

            Console.WriteLine("Any items: " + list.Any());

            list.Remove(2);
            Console.WriteLine("Removed 2. Contains 2: " + list.Contains(2));

            list.Clear();
            Console.WriteLine("Cleared list. Any items: " + list.Any());
        }
    }
