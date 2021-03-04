using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            _225_ImplementStackUsingQueue stack = new _225_ImplementStackUsingQueue();

            stack.Push(1);
            

            int num = stack.Pop();
            Console.WriteLine(num);

            Console.ReadLine();

        }
    }
}
