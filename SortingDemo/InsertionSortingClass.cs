using System;

namespace SortingDemo
{
    public class InsertionSortingClass
    {
        public static void InsertionSort(int[] items)
        {
            for (int i = 1; i < items.Length; i++)
            {
                int key = items[i];
                int j = i - 1;
                while (j >= 0 && items[j] > key)
                {
                    items[j + 1] = items[j];    // Right shift element
                    j = j - 1;
                }
                items[j + 1] = key;
            }
        }
    }
}