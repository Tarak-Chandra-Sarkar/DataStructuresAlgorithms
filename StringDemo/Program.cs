using System;
using System.Collections.Generic;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Demo");
            Console.WriteLine();

            #region RemoveDuplicateCharacterFromString
            // RemoveDuplicateCharacterFromString();
            #endregion

            #region CheckTwoStringAnagram
            // CheckTwoStringAnagram();
            #endregion

            #region ReverseString
            // ReverseString();
            // Console.WriteLine($"google reverse = {ReverseByRecursive("google")}");
            #endregion

            #region NumbersOfWords
            // NumbersOfWords();
            #endregion

            #region CheckPalindromeString
            // CheckPalindromeString();
            #endregion

            #region FindAllSubstrings
            FindAllSubstrings();
            #endregion
        }

        #region RemoveDuplicateCharacterFromString Methods
        private static void RemoveDuplicateCharacterFromString()
        {
            string str = "google";
            Console.WriteLine($"Before Remove Duplicate = {str}");
            Console.WriteLine();

            string table = string.Empty;
            string result = string.Empty;

            foreach (char c in str)
            {
                if (table.IndexOf(c) == -1)
                {
                    table = table + c;
                    result = result + c;
                }
                else
                {
                    table = table + c;
                }
            }

            Console.WriteLine($"After Remove Duplicate = {result}");
        }
        #endregion

        #region CheckTwoStringAnagram Methods
        private static void CheckTwoStringAnagram()
        {
            // Anagrams example post->opts
            string word1 = "silent";
            string word2 = "listen";

            char[] strChar1 = word1.ToLower().ToCharArray();
            char[] strChar2 = word2.ToLower().ToCharArray();

            // Sort in same order
            Array.Sort(strChar1);
            Array.Sort(strChar2);

            string newWord1 = new String(strChar1);
            string newWord2 = new String(strChar2);

            if (newWord1.Equals(newWord2))
            {
                Console.WriteLine($"{word1} & {word2} are Anagram");
            }
            else
            {
                Console.WriteLine($"{word1} & {word2} are NOT Anagram");
            }
        }
        #endregion

        #region NumbersOfWords Methods
        private static void NumbersOfWords()
        {
            string str = "Welcome to the Hello World";
            str = str.Trim();
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($" Words Count of '{str}' = {words.Length}");
        }
        #endregion

        #region ReverseString Methods
        private static void ReverseString()
        {
            string word = "Microsoft";
            Console.WriteLine($"Before Reverse = {word}");

            string result = string.Empty;
            for (int i = word.Length - 1; i  >= 0; i--)
            {
                result = result + word[i];
            }

            Console.WriteLine($"After Reverse = {result}");
        }
        private static string ReverseByRecursive(string str)
        {
            if (str.Length > 1)
            {
                int len = str.Length;
                return str.Substring(len - 1) + ReverseByRecursive(str.Substring(0, len - 1));
            }
            else
            {
                return str.Substring(0);
            }
        }
        #endregion

        #region CheckPalindromeString Methods
        private static void CheckPalindromeString()
        {
            string str = "Madam";
            bool palindrom = true;

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i].ToString().ToLower() != str[str.Length -1 - i].ToString().ToLower())
                {
                    Console.WriteLine($"{str}  is NOT Palindrom");
                    palindrom = false;
                    break;
                }
            }
            if (palindrom)
            {
                Console.WriteLine($"{str}  is Palindrom");
            }
        }
        #endregion

        #region FindAllSubstrings
        private static void FindAllSubstrings()
        {
            string str = "rstuvwxyz";

            for (int length = 1; length < str.Length; length++)
            {
                for (int start = 0; start <= str.Length - length; start++)
                {
                    Console.WriteLine(str.Substring(start, length));
                }
            }
        }
        #endregion

    }
}
