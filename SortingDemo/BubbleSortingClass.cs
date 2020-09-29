using System;
using System.Collections.Generic;
using System.Text;

namespace SortingDemo
{
    public class BubbleSortingClass
    {
        #region Bubble Sort Methods
        public static void BubbleSort(int[] items)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }

            } while (swapped != false);
        }
        #endregion

        #region Swap Method
        private static void Swap<T>(T[] items, int left, int right)
        {
            T temp = items[left];
            items[left] = items[right];
            items[right] = temp;
        }
        #endregion
    }
}
