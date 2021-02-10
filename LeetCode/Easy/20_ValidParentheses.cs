using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class _20_ValidParentheses
    {
        public static bool IsValid(string s)
        {
            bool result = true;
            int parentheses = 0;
            int curly = 0;
            int square = 0;

            char[] charArr = s.ToCharArray();

            foreach(char chr in charArr)
            {
                switch (chr)
                {
                    case '[':
                        parentheses += 1;
                        break;
                    case ']':
                        parentheses -= 1;
                        break;
                    case '{':
                        curly += 1;
                        break;
                    case '}':
                        curly -= 1;
                        break;
                    case '(':
                        square += 1;
                        break;
                    case ')':
                        square -= 1;
                        break;
                }
            }

            result = parentheses < 1 && curly < 1 && square < 1;
            Console.WriteLine($"{parentheses} {curly} {square}");
            return result;
        }

    }
}
