using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "i love eating burger";
            string searchWord = "burg";
            int result = _1455_CheckIfPrefix.IsPrefixOfWord(sentence, searchWord);

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
