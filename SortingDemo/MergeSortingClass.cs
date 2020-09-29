using System;

namespace SortingDemo
{
    public class MergeSortingClass
    {
        /// <summary>
        /// Main function that sorts items[leftIndex..rightIndex] using 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="leftIndex"></param>
        /// <param name="rightIndex"></param>
        public static void MergeSort(int[] items, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int midIndex = (rightIndex + leftIndex) / 2;

                MergeSort(items, leftIndex, midIndex);
                MergeSort(items, midIndex + 1, rightIndex);

                Merge(items, leftIndex, midIndex, rightIndex);
            }
        }

        /// <summary>
        /// Merges two subarrays of items[].
        /// First subarray is items[leftIndex..midIndex] 
        /// Second subarray is arr[midIndex+1..rightIndex]
        /// </summary>
        /// <param name="items"></param>
        /// <param name="leftIndex"></param>
        /// <param name="midIndex"></param>
        /// <param name="rightIndex"></param>
        private static void Merge(int[] items, int leftIndex, int midIndex, int rightIndex)
        {
            // Find sizes of two subarrays to be merged 
            int n1 = midIndex - leftIndex + 1;
            int n2 = rightIndex - midIndex;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int i1 = 0; i1 < n1; i1++)
            {
                L[i1] = items[leftIndex + i1];
            }

            for (int i2 = 0; i2 < n2; i2++)
            {
                R[i2] = items[midIndex + 1 + i2];
            }

            int i = 0;
            int j = 0;
            int k = leftIndex;

            while (i < n1 && j < n2)
            {
                if(L[i] <= R[j])
                {
                    items[k] = L[i];
                    i++;
                }
                else
                {
                    items[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                items[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                items[k] = R[j];
                j++;
                k++;
            }

        }
    }
}