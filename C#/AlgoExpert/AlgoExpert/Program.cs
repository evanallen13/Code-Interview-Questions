using System;
using System.Collections.Generic;

namespace AlgoExpert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };

            _01_ValidateSubsequence.IsValidSubsequence(array, sequence);
            Console.ReadLine();
        }
    }
}
