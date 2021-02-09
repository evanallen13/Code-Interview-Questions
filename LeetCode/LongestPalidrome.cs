using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // Given a string s, return the longest palindromic substring in s.
    class LongestPalidrome
    {
        public static string longestPalindrome(string s)
        {
            string result = string.Empty;

            for (int i = 0; i <= s.Length; i++)
            {
                string remaining = s.Substring(i, s.Length - i);
                for (int j = 0; j <= remaining.Length; j++)
                {
                    string str2 = s.Substring(i, j);
                    if (isPalidrome(str2))
                    {
                       if(result.Length <= str2.Length)
                        {
                            result = str2;
                        }
                    }

                }
            }

            return result;
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
