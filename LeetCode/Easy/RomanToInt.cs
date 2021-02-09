using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class RomanToInt
    {
        public static int romanToInt(string s)
        {
            char[] charArr = s.ToCharArray();
            int result = 0;

            for(int i = 0; i < charArr.Length; i++)
            {
                result += convertNumeral(charArr[i], 'd');
            }

            return result;
        }

        public static int convertNumeral(char numeral1, char numeral2)
        {
            if (Array.IndexOf(, numeral1) > -1)
            {

            }
            switch (numeral1)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
