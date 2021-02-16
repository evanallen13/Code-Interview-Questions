using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _038_CountAndSay
    {

        public static string CountAndSay(int n)
        {
            char[] charArray = n.ToString().ToCharArray();
            string result = String.Empty;

            for(int i = 0; i < charArray.Length; i++)
            {
                int j = i + 1;
                while (true)
                {
                    char current = charArray[i];
                    char next = charArray[j];
                    if (current == next)
                    {

                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }


    }
}
