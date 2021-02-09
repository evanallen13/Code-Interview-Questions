﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class IsPalindrome
    {
        public static bool isPalindrome(int x)
        {
            string str = x.ToString();
            string reverse = string.Empty;
            int i = str.Length - 1;

            while (i >= 0)
            {
                reverse += str[i];
                i--;
            }

            return str == reverse;
        }
    }
}
