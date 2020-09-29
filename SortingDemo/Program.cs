using System;

namespace SortingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
              #region Bubble Sort
            int[] items = {3, 7, 4, 4, 6, 5, 8};            

            //Before Sorting
            Console.Write("Before Sorting: ");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            // Bubble Sort
            // BubbleSortingClass.BubbleSort(items);

            // Selection Sort
            // SelectionSortingClass.SelectionSort(items);

            // Insertion Sort
            // InsertionSortingClass.InsertionSort(items);

            // Merge Sort
            MergeSortingClass.MergeSort(items, 0, items.Length - 1);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("After Sorting:  ");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion
        }

        

        
    }
}
