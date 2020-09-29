using System;

namespace DataStructuresAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListDemoClass<int> linkedListDemoClass = new LinkedListDemoClass<int>();

            // Add Noe values
            linkedListDemoClass.Add(1);
            linkedListDemoClass.Add(3);
            linkedListDemoClass.Add(5);
            linkedListDemoClass.Add(7);

            Console.WriteLine("All Node values:");
            // Print all LinkedList values
            linkedListDemoClass.PrintList();

            int itemToRemove = 1; 
            // Remove Node 
            linkedListDemoClass.Remove(itemToRemove);

            Console.WriteLine($"After Removing Node value {itemToRemove}:");

            linkedListDemoClass.PrintList();

            // Check whether given value exist or not
            int itemToSearch = 5;
            bool searchResult = linkedListDemoClass.Contains(5);
            Console.WriteLine($"The node { itemToSearch} exists: {searchResult}");

            Console.WriteLine("ForEach item:");
            foreach (var item in linkedListDemoClass)
            {
                Console.WriteLine(item);
            }

            //linkedListDemoClass.Clear();
            //Console.WriteLine("After Clear() method call:-");
            //foreach (var item in linkedListDemoClass)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("After CopyTo() methods in Array");
            int[] array = new int[5];
            linkedListDemoClass.CopyTo(array, 0);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"LinkedList Count: {linkedListDemoClass.Count}");

            // Doubly Linked List
            Console.WriteLine("+++++++++++++++++++++++++++++Doubly linked List++++++++++++++++++++++++++++++");
            LinkedListDoublyClass<int> doublyList = new LinkedListDoublyClass<int>();

            doublyList.Add(1);
            doublyList.Add(3);
            doublyList.Add(5);
            doublyList.Add(7);

            foreach (var item in doublyList)
            {
                Console.WriteLine(item);
            }

            doublyList.RemoveFirst();

            Console.WriteLine("After RemoveFirst()");
            foreach (var item in doublyList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ProcessListBackwards or Reverse order");
            ProcessListBackwards(doublyList);

        }

        private static void ProcessListBackwards(LinkedListDoublyClass<int> list)
        {
            LinkedListDoublyNode<int> current = list.Tail;
            while (current != null)
            {
                ProcessNode(current);
                current = current.Previous;
            }
        }

        private static void ProcessNode(LinkedListDoublyNode<int> current)
        {
            Console.WriteLine(current.Value);
        }
    }
}
