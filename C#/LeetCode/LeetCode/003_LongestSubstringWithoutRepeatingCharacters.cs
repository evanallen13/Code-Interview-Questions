using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _003_LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            string currentString = string.Empty;
            string longestString = string.Empty;
            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (i > 0)
                {
                    if (currentString.IndexOf(chars[i]) < 0)
                        currentString += chars[i];
                    else
                        currentString = chars[i].ToString();
                }
                else
                {
                    currentString += chars[i];
                }
            }

            return longestString.Length;
        }
    }
}
