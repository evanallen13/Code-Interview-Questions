using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            try
            {
                Boolean isNegative = x < 0;
                x = Math.Abs(x);
                int xLen = x.ToString().Length;
                char[] numbers = new char[xLen];
                string result = string.Empty;

                numbers = x.ToString().ToCharArray();

                for (int i = xLen - 1; i >= 0; i--)
                {
                    result += numbers[i];
                }
                return isNegative ? int.Parse(result) * -1 : int.Parse(result);

            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
