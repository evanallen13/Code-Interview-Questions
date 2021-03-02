using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();

            minStack.push(2);
            minStack.push(0);
            minStack.push(3);
            minStack.push(3);
            minStack.getMin();
            minStack.pop();
            minStack.getMin();
            minStack.pop();
            minStack.getMin();
            minStack.pop();
            minStack.getMin();

            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
