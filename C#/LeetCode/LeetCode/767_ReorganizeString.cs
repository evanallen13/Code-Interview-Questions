using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _767_ReorganizeString
    {
        public static string ReorganizeString(string S)
        {
            char[] charArr = S.ToString().ToCharArray();
            
            int n = charArr.Length - 2;

            for (int i = 1; i <= n; i++)
            {
                char current = charArr[i];
                char previous = charArr[i - 1];
                char next = charArr[i + 1];

                if(current == previous)
                {
                    charArr[i] = next;
                    charArr[i + 1] = current;
                }
            }

            return new string(charArr);
        }
    }
}
