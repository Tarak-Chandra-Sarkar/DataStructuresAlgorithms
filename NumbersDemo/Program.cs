using System;

namespace NumbersDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region SwapNumbersWithoutTempVariable
            /*
            Console.WriteLine("Swap without temp variable: ");            
            SwapNumbersWithoutTempVariable();
            Console.WriteLine();
            SwapNumbersWithoutTempVariableUsingXOR();
            */
            #endregion

            #region TotalWaysToStairStep
            /*
            Console.WriteLine("Total Ways To Stair Step:");
            int n = 10;
            TotalWaysToStairStep(n);
            Console.WriteLine(n);
            */
            #endregion

            #region FactorialUsingRecursion
            /*
            int n = 5;
            int result = FactorialUsingRecursion(n);
            Console.WriteLine($"Factorial of {n} = {result}");
            */
            #endregion

            #region FibonacciSeries
            /*
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                int result = FibonacciSeries(i);
                Console.Write($" {result}");
            }
            */
            #endregion

            #region CheckArmstrongNumber
            // CheckArmstrongNumber();
            #endregion

            #region FindGCDAndLCM
            // FindGCDAndLCM();
            #endregion

            #region CheckPrimeNumber
            // CheckPrimeNumber();
            #endregion

            #region CheckPalindromeNumber
            // CheckPalindromeNumber();
            #endregion

        }

        #region SwapNumbersWithoutTempVariable Methods
        private static void SwapNumbersWithoutTempVariable()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before Swap a = {a} & b = {b}");
            Console.WriteLine();

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After  Swap a = {a} & b = {b}");
        }

        private static void SwapNumbersWithoutTempVariableUsingXOR()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before Swap using XOR a = {a} & b = {b}");
            Console.WriteLine();

            a = b ^ a;  // b ^ a
            b = b ^ a;  // b ^ b ^ a => 0 ^ a => a  (as 0 ^ 1 = 1 & 1 ^ 1 = 0)
            a = a ^ b;  // b ^ a ^ a => b ^ 0 => b  (as 1 ^ 0 = 1)

            Console.WriteLine($"After  Swap using XOR a = {a} & b = {b}");
        }
        #endregion

        #region TotalWaysToStairStep Methods
        // A child is running up a staircase with n steps, and can hop either 1, 2, or 3 steps at a time.  Implement a method to count how many possible ways the child can run up the stairs.
        //Answer will overflow integer datatype(over 4 billion) at 37 steps
        public static int TotalWaysToStairStep(int numStairs)
        {
            // Exception Case
            if (numStairs > 36)
            {
                throw new ArgumentException("Integer Overflow");
            }
            // Base Case
            if (numStairs == 0)
            {
                return 0;
            }
            if (numStairs == 1)
            {
                return 1;
            }
            if (numStairs == 2)
            {
                return 2;
            }
            if (numStairs == 3)
            {
                return 4;
            }

            // Recursive Case
           return TotalWaysToStairStep(numStairs - 1) + TotalWaysToStairStep(numStairs -2) + TotalWaysToStairStep(numStairs - 3);
        }
        #endregion

        #region FactorialUsingRecursion Methods
        public static int FactorialUsingRecursion(int n)
        {
            // Base case
            if (n == 1)
            {
                return 1;
            }

            //Recursive Case
            return n * FactorialUsingRecursion(n - 1);
        }
        #endregion

        #region FibonacciSeries Methods
        public static int FibonacciSeries(int n)
        {
            // Base Case
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            // Recursive Case
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
        #endregion

        #region CheckArmstrongNumber Methods
        public static bool CheckArmstrongNumber()
        {
            int n = 371;
            int times = 0;
            int temp = n;
            while (temp != 0)
            {
                times++;
                temp = temp / 10;
            }

            int reminder = 0, sumDigitsCube = 0;
            temp = n;
            while(temp != 0)
            { 
                reminder = temp % 10;
                sumDigitsCube = sumDigitsCube + GetPower(reminder, times);
                temp = temp / 10;
            }
            if (sumDigitsCube == n)
            {
                Console.WriteLine($"{n} is Armstrong Number");
                return true;
            }
            else
            {
                Console.WriteLine($"{n} is NOT Armstrong Number");
                return false;
            }
        }

        private static int GetPower(int number, int times)
        {
            if (number == 1)
            {
                return 1;
            }
            int x = 1;
            for (int i = 0; i < times; i++)
            {
                x = x * number;
            }
            return x;
        }
        #endregion

        #region FindGCDAndLCM Methods
        public static void FindGCDAndLCM()
        {
            int x = 10, y = 135;
            int gcd = GCD(x, y);

            Console.WriteLine($"GCD of {x}, {y} is {gcd}");

            int lcm = (x * y) / gcd;

            Console.WriteLine($"LCM of {x}, {y} is {lcm}");
        }

        private static int GCD(int x, int y)
        {
            if (x == 0)
            {
                return y;
            }
            if (y == 0)
            {
                return x;
            }

            if(x > y)
            {
                return GCD(x % y, y);
            }
            else
            {
                return GCD(x, y % x);
            }
        }
        #endregion

        #region CheckPrimeNumber Methods
        public static void CheckPrimeNumber()
        {
            int number = 11;
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                Console.WriteLine($"{number} is Prime ");
            }
            else
            {
                Console.WriteLine($"{number} is NOT Prime ");
            }

        }
        #endregion

        #region CheckPalindromeNumber Methods
        public static void CheckPalindromeNumber()
        {
            int number = 121;
            int reverseNumber = Reverse(number);
            if (number == reverseNumber)
            {
                Console.WriteLine($"{number} is Palindromic Number");
            }
            else
            {
                Console.WriteLine($"{number} is NOT Palindromic Number");
            }
        }

        private static int Reverse(int num)
        {
            int reminder, reverseNum = 0;
            while (num != 0)
            {
                reminder = num % 10;
                reverseNum = reverseNum * 10 + reminder;
                num /= 10;
            }
            return reverseNum;
        }
        #endregion
    }
}
