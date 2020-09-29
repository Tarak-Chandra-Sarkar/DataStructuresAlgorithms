using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation
{
    public class BitManipulationUsage
    {
        public static void Demo()
        {
            // Sparse Bit Count technique
            Console.WriteLine();
            Console.WriteLine("Sparse Bit Count technique:");
            Console.WriteLine("Input (In Decimal)  =>  Count  ");
            Console.WriteLine($"0 => {SparseBitCount(0)}");
            Console.WriteLine($"1 => {SparseBitCount(1)}");
            Console.WriteLine($"4 => {SparseBitCount(4)}");
            Console.WriteLine($"6 => {SparseBitCount(6)}");
            Console.WriteLine($"int.MaxValue => {SparseBitCount(int.MaxValue)}");
            Console.WriteLine($"256 => {SparseBitCount(256)}");
            Console.WriteLine();
            Console.WriteLine(CountBits(0));
            Console.WriteLine(CountBits(1));
            Console.WriteLine(CountBits(4));
            Console.WriteLine(CountBits(6));
            Console.WriteLine(CountBits(int.MaxValue));
            Console.WriteLine(CountBits(256));

        }

        /// <summary>
        /// This Simple Algo that walks through all the bits that are set to 1 (one)
        /// When we do bitwise AND between (number) & (number - 1), Right most SET(1) bit
        /// of number will be UnSET(0).
        /// So number SET bit = Iteration required till number becomes 0.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SparseBitCount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n & (n - 1);
            }

            return count;
        }

        /// <summary>
        /// Check whether Right most bit of number is SET or not.
        /// If SET, we increament counter
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountBits(int n)
        {
            int numBits = 0;
            while (n != 0)
            {
                numBits = numBits + (n & 1);
                n = n >> 1;
            }
            return numBits;
        }
    }
}
