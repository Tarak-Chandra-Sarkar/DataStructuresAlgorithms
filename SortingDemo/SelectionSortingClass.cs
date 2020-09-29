using System;

namespace SortingDemo
{
    public class SelectionSortingClass
    {
        public static void SelectionSort(int[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < items.Length; j++)
                {
                    if(items[j] < items[i])
                    {
                        minIndex = j;
                    }
                }

                // Swap
                int temp = items[minIndex];
                items[minIndex] = items[i];
                items[i] = temp;

            }
        }
    }
}