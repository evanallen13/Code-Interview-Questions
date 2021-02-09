using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class _20_ValidParentheses
    {
        public static bool IsValid(string s)
        {
            //// [ Open, Closed, Broken ]
            bool[] parentheses =    new bool[]{ false, true, false };
            bool[] curly =          new bool[]{ false, true, false };
            bool[] square =         new bool[]{ false, true, false };

            char[] charArr = s.ToUpper().ToCharArray();

            foreach (char chr in charArr)
            {


                if(parentheses[2] && curly[2] && square[2])
                {
                    break;
                }
            }

            bool isOpen =   parentheses[0] && curly[0] && square[0];
            bool isClosed = parentheses[1] && curly[1] && square[1];
            bool isBroken = parentheses[2] || curly[2] || square[2];

            return !isOpen && isClosed && !isBroken;
        }

        public static bool  open(bool[] arr, char bracket)
        {
            switch (bracket)
            {
                case '}':
                case ']':
                case ')':
                    if (!arr[0] && arr[1])
                    {
                        arr[0] = true;
                        arr[1] = false;
                    }
                    else
                    {
                        arr[2] = true;
                    }

                    break;

                case '{':
                case '[':
                case '(':
                    if (arr[0] && !arr[1])
                    {
                        arr[0] = false;
                        arr[1] = true;
                    }
                    else
                    {
                        arr[2] = true;
                    }

                    break;
            }
            return false;
        }
    }
}
