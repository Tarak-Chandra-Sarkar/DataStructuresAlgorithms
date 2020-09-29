using System;
using System.Collections.Generic;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RotateRightShift
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //int k = 3;

            //RotateArray(nums, k);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region ReplaceElementsGreaterThan
            //// int[] arr = { 17, 18, 5, 4, 6, 1 };
            //int[] arr = { 17, 18, 19, 20, 21, 22 };
            //int[] arr2 = ReplaceElementsGreaterThan(arr);
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region SortArrayByParity
            //int[] A = { 3, 1, 2, 4 };
            //A = SortArrayByParity(A);

            //foreach (var item in A)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region SquareOfSortedArray
            //int[] A = { -4, -1, 0, 3, 10 };

            //A = SquareOfSortedArray(A);

            //foreach (var item in A)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region MajorityElement
            //int[] nums = {3, 2, 3};
            //int majorityElement = MajorityElement(nums);
            //Console.WriteLine($"Majority Element id {majorityElement}");
            #endregion

            #region MergeTwoSortedArray
            ////int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            ////int[] nums2 = { 2, 5, 6 };
            ////int m = 3, n = 3;

            //int[] nums1 = { 0 }; // Corner Case
            //int[] nums2 = { 1 };
            //int m = 0, n = 1;

            //MergeTwoSortedArray(nums1, m, nums2, n);
            //foreach (var item in nums1)
            //{
            //    Console.Write($" {item}");
            //}
            #endregion

            #region TwoSumToTargetNumber
            /*
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] arr = TwoSumToTarget(nums, target);
            foreach (var item in arr)
            {
                Console.Write($" {item}");
            }
            */
            #endregion

            #region ContainDuplicates
            /*
            int[] nums = { 1, 2, 3, 1 };
            bool result = ContainsDuplicate(nums);
            */
            #endregion

            #region MovesZeroesToEndOfArray
            /*
            // In-Place Two - Pointer Mechanism
            int[] nums = { 0, 1, 0, 3, 12 };
            MovesZeroesToEnd(nums);
            foreach (var num in nums)
            {
                Console.Write($" {num}");
            }
            */
            #endregion

            #region RotateArrayToRightToPivot
            /*
            int[] nums = { 1, 3, 7, 12, 23, 9, 4 };
            int pivot = 3;
            Console.WriteLine("Before Rotate to Pivote: ");
            foreach (var num in nums)
            {
                Console.Write($" {num}");
            }
            RotateArrayToRightToPivot(nums, pivot);
            Console.WriteLine();
            Console.WriteLine("Before Rotate to Pivote: ");
            foreach (var num in nums)
            {
                Console.Write($" {num}");
            }
            */
            #endregion

            #region MissingNumbersOfArray1To100
            /*
            int[] nums = { 1, 2, 4, 6, 8, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] missingNumbers = MissingNumbersOfArray1To100(nums);
            foreach (var num in missingNumbers)
            {
                Console.Write($" {num}");
            }
            */
            #endregion
        }


        #region RotateRightShift Methods
        // Time = O(n^2) Space = O(1)
        private static void RotateArray(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                RotateRightByOne(nums, k);
            }
        }

        private static void RotateRightByOne(int[] nums, int k)
        {
            int j;
            int temp;

            temp = nums[nums.Length - 1];
            for (j = nums.Length - 1; j > 0; j--)
            {
                nums[j] = nums[j - 1];
            }

            nums[j] = temp;
        }
        #endregion

        #region ReplaceElementsGreaterThan Methods
        private static int[] ReplaceElementsGreaterThan(int[] arr)
        {
            int i = 1;

            while (i <= arr.Length - 1)
            {
                if (arr[i - 1] < arr[i])
                {
                    i++;
                }
                else
                {
                    int tempMax = arr[i];
                    for (int j = i - 1; j >= 0 && arr[j + 1] > arr[j]; j--)
                    {
                        arr[j] = tempMax;
                    }
                    arr[i] = arr[i + 1];
                    i++;
                }
            }
            return arr;
        }
        #endregion

        #region SortArrayByParity Methods
        private static int[] SortArrayByParity(int[] A)
        {
            int evenNumIndex = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] % 2) == 0)
                {
                    int temp = A[evenNumIndex];
                    A[evenNumIndex] = A[i];
                    A[i] = temp;

                    evenNumIndex++;
                }
            }

            return A;
        }
        #endregion

        #region SquareOfSortedArray Methods
        private static int[] SquareOfSortedArray(int[] A)
        {
            int i = 0; //for negative number

            while (i < A.Length && A[i] < 0)
            {
                i++;
            }

            int j = i - 1; //for Positive Numbers
            int p = 0; // to hold pointer

            while (j >= 0 && i < A.Length)
            {
                if (A[j] * A[j] < A[i] * A[i])
                {
                    A[p++] = A[j] * A[j];
                    j--;
                }
                else
                {
                    A[p++] = A[i] * A[i];
                    i++;
                }
            }

            while (j >= 0)
            {
                A[p++] = A[j] * A[j];
                j--;
            }

            while (i < A.Length)
            {
                A[p++] = A[i] * A[i];
                i++;
            }

            return A;
        }

        #endregion

        #region MajorityElement Methods
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int majority = nums.Length / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                    if (dict[nums[i]] > majority)
                    {
                        return nums[i];
                    }
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            throw new Exception("No Majority element in tha array.");

        }
        #endregion

        #region MergeTwoSortedArray Methods
        public static void MergeTwoSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (j >= 0)
            {
                if (i >= 0 && (nums1[i] > nums2[j]))
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }

                k--;
            }
        }
        #endregion

        #region TwoSumToTargetNumber Methods
        // Time = O(n^2) Space = O(n)
        /*
        public int[] TwoSumToTarget(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && (nums[i] + nums[j]) == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { 0, 0 };
        }
        */
        
        /* Use of HashSet to get two integer sums to target
        public static int[] TwoSumToTarget(int[] nums, int target)
        {
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (hashSet.Contains(temp))
                {
                    return new int[] { temp, nums[i] };
                }
                hashSet.Add(nums[i]);
            }
            return new int[] { 0, 0 };
        }
        */

        // Using Dictionary to map elements
        // Time = O(n) Space = O(n)
        public static int[] TwoSumToTarget(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (dict.ContainsKey(temp))
                {
                    return new int[] { int.Parse(dict[temp].ToString()), i };
                }
                dict.Add(nums[i], i);
            }
            throw new ArgumentException("No Two Sum Solution");
        }
        #endregion

        #region ContainDuplicates Methods
        // Time = O(n) & Space = O(n)
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    return true;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            return false;
        }
        #endregion

        #region MovesZeroesToEndOfArray Methods
        public static void MovesZeroesToEnd(int[] nums)
        {
            int nonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    //swap
                    int temp = nums[nonZeroIndex];
                    nums[nonZeroIndex] = nums[i];
                    nums[i] = temp;

                    nonZeroIndex++;
                }
            }
        }
        #endregion

        #region RotateArrayToRightToPivot Methods
        // Time = O(n) Space = O(1)
        public static void RotateArrayToRightToPivot(int[] nums, int pivot)
        {
            if (pivot < 0 || nums == null)
            {
                throw new ArgumentException("InvalidCastException Arguments");
            }

            pivot = pivot % nums.Length;

            //Rotate First Half
            RotateSub(nums, 0, pivot - 1);

            //Rotate First Half
            RotateSub(nums, pivot, nums.Length - 1);


            //Rotate First Half
            RotateSub(nums, 0, nums.Length - 1);
        }

        public static void RotateSub(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;

                start++;
                end--;
            }
        }
        #endregion

        #region MissingNumbersOfArray1To100 Methods
        public static int[] MissingNumbersOfArray1To100(int[] nums)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            foreach (var num in nums)
            {
                dict.Add(num, true);
            }
            int length = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, false);
                    length++;
                }
            }

            int[] retArr = new int[length];
            int index = 0;

            foreach (var item in dict.Keys)
            {
                if (dict[item] == false)
                {
                    retArr[index++] = item;
                }
            }

            return retArr;
        }
        #endregion


    }
}
