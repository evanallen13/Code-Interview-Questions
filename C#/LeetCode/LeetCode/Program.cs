using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {


            string s = "[";
            Console.WriteLine(_020_ValidParetheses.IsValid(s));

            s = "[]";
            Console.WriteLine(_020_ValidParetheses.IsValid(s));

            Console.ReadLine();

        }
    }
}
