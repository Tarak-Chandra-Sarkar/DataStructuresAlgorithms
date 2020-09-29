using System;

namespace BitManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BitWise Complement:");
            BitWiseComplement();

            Console.WriteLine();

            Console.WriteLine("BitWise AND:");
            BitWiseAND();

            Console.WriteLine();

            Console.WriteLine("BitWise OR:");
            BitWiseOR();

            Console.WriteLine();

            Console.WriteLine("BitWise XOR:");
            BitWiseXOR();

            Console.WriteLine();

            Console.WriteLine("BitWise Left Shift (<<):");
            BitWiseLeftShift();

            Console.WriteLine();

            Console.WriteLine("BitWise Right Shift (>>):");
            BitWiseRightShift();

            // Bit Manipulation Usage demo
            BitManipulationUsage.Demo();


        }        

        /// <summary>
        /// ~ operator inverts each bits
        /// i.e. changes 1 to 0 and 0 to 1.
        /// </summary>
        private static void BitWiseComplement()
        {
            // 26 = 00011010 (In Binary)
            // ~00011010 = 11100101 = 229 (In Decimal)
            // but result is -27 because 11100101 expected to be 
            // 229 is actually 2's Complement of -27
            // For any integer n, 2's Complement of n will be -(n + 1).
            int number = 26;
            int result = ~number;
            Console.WriteLine($"~{number} = {result}");
        }


        private static void BitWiseAND()
        {
            // 14 = 00001110 (In Binary) , 11 = 00001011 (In Binary)
            // 14 & 11 => 00001110 
            //               & 
            //            00001011
            //          -------------
            //            00001010 = 10 (In Decimal)

            int number1 = 14, number2 = 11;
            int result = number1 & number2;
            Console.WriteLine($"{number1} & {number2} = {result}");
        }

        private static void BitWiseOR()
        {
            // 14 = 00001110 (In Binary) , 11 = 00001011 (In Binary)
            // 14 & 11 => 00001110 
            //               | 
            //            00001011
            //          -------------
            //            00001111= 15 (In Decimal)
            int number1 = 14, number2 = 11;
            int result = number1 | number2;
            Console.WriteLine($"{number1} | {number2} = {result}");
        }

        private static void BitWiseXOR()
        {
            // 14 = 00001110 (In Binary) , 11 = 00001011 (In Binary)
            // 14 & 11 => 00001110 
            //              ^(XOR)
            //            00001011
            //          -------------
            //            00000101= 5 (In Decimal)
            int number1 = 14, number2 = 11;
            int result = number1 ^ number2;
            Console.WriteLine($"{number1} ^ {number2} = {result}");
        }

        private static void BitWiseLeftShift()
        {
            // << operator shifts a number to the left specified number of bits.
            // Zeroes are added to the least significant bits.
            // In decimal, it is equivalent to (num * 2bits)
            // i.e. 42 = 101010 (In Binary)
            // 42 << 1 = 84 (In Binary 1010100)
            // 42 << 2 = 168 (In Binary 10101000)
            // 42 << 3 = 336 (In Binary 101010000)
            // 42 << 4 = 672 (In Binary 1010100000)
            int number = 42;
            Console.WriteLine($"{number} << 1 = {number << 1}");
            Console.WriteLine($"{number} << 2 = {number << 2}");
            Console.WriteLine($"{number} << 3 = {number << 3}");
            Console.WriteLine($"{number} << 4 = {number << 4}");
        }

        private static void BitWiseRightShift()
        {
            // >> operator shifts a number to the right specified number of bits.
            // Zeroes are added to the Most significant bits.
            // In decimal, it is equivalent to Floor(num / 2bits)
            // i.e. 42 = 101010 (In Binary)
            // 42 << 1 = 21 (In Binary 010101)
            // 42 << 2 = 10 (In Binary 001010)
            // 42 << 3 = 5 (In Binary 000101)
            // 42 << 4 = 2 (In Binary 000010)
            int number = 42;
            Console.WriteLine($"{number} >> 1 = {number >> 1}");
            Console.WriteLine($"{number} >> 2 = {number >> 2}");
            Console.WriteLine($"{number} >> 3 = {number >> 3}");
            Console.WriteLine($"{number} >> 4 = {number >> 4}");
        }
    }
}
