using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _005_LongestPalidromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length <= 1) return s;
            string longestPalindrome = string.Empty;

            for (int i = 0; i < s.Length; i++){

                int n = i + longestPalindrome.Length;
                if (n >= s.Length) break;
                for (int j = n; j < s.Length; j++)
                {
                    string remaining = s.Substring(i, j);

                    if (isPalidrome(remaining))
                        longestPalindrome = remaining;
                }
            }

           return longestPalindrome;
        }

        public static bool isPalidrome(string str1)
        {
            char[] charArray = str1.ToCharArray();
            Array.Reverse(charArray);
            string str2 = new string(charArray);

            return str1 == str2;
        }

    }
}
