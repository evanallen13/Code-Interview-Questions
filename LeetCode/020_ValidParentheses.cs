using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class _20_ValidParentheses
    {
        public static bool IsValid(string s)
        {
            if (s == null || s == string.Empty)
                return true;

            bool result = true;
            int parentheses = 0;
            int curly = 0;
            int square = 0;

            char[] charArr = s.ToCharArray();

            foreach (char chr in charArr)
            {
                switch (chr)
                {
                    ///// SQUARE
                    case '[':
                        if (curly == 0 && parentheses == 0)
                        {
                            square += 1;
                        }
                        else
                        {
                            result = false;
                        }
                        break;
                    case ']':
                        if (curly % 2 != 0 && parentheses == 0)
                        {
                            square -= 1;
                        }
                        else
                        {
                            result = false;
                        }
                        break;
                    /// CURLY
                    case '{':
                        if (square == 0 && parentheses == 0)
                        {
                            curly += 1;
                        }
                        else
                        {
                            result = false;
                        }
                        break;
                    case '}':
                        if (square == 0 && parentheses == 0)
                        {
                            curly -= 1;
                        }
                        else
                        {
                            result = false;
                        }

                        break;

                    // PARENTHESES
                    case '(':
                        if (square == 0 && curly == 0)
                        {
                            parentheses += 1;
                        }
                        else
                        {
                            result = false;
                        }
                        break;
                    case ')':
                        if (square == 0 && curly == 0)
                        {
                            parentheses -= 1;
                        }
                        else
                        {
                            result = false;

                        }
                        break;
                }

                if (!result)
                {
                    break;
                }
            }

            result = parentheses < 1 && curly < 1 && square < 1 && result;
            Console.WriteLine($"{s}");
            return result;
        }

    }
}
