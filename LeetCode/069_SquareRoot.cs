using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class _69_SquareRoot
    {
        public static int MySqrt(int x)
        {
            int result = 0;
            while (result <= x)
            {
                if (result * result == x)
                {
                    break;
                }
                else
                {
                    result += 1;
                }
            }

            return result;
        }
    }
}
