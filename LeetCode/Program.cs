using System;
using LeetCode.DataStuctures;
using LeetCode.Questions;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -345;
            Console.Write(Reverse(x));
        }

        public static int Reverse(int x)
        {
            bool isNeg = x < 0;
            x = Math.Abs(x);

            char[] xString = x.ToString().ToCharArray();

            int l = 0;
            int r = xString.Length - 1;

            while (l <= r)
            {
                char lNum = xString[l];
                char rNum = xString[r];

                xString[r] = lNum;
                xString[l] = rNum;

                l++;
                r--;
            }
            return  isNeg ? - int.Parse(xString): int.Parse(xString);
        }
    }
}

