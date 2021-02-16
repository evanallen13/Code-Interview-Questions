using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _066_PlusOne
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            digits[n - 1] = digits[n - 1] + 1;

            for (int i = n - 1; i >= 0; i--)
            {
                int current = digits[i];
                int next = digits[i - 1];
                if (current > 9)
                {
                    digits[i] = 9;
                    digits[i - 1] = next + 1;
                }
            }

            int first = digits[0];
            if (first >= 10)
            {
                int[] newArr = new int[n + 1];
                newArr[0] = 1;
                return newArr;
            }
            else
            {
                return digits;
            }
        }
    }
}
