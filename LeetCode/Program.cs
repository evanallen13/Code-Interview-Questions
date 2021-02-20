using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //string S = "vvvlo";

            //string result = _767_ReorganizeString.ReorganizeString(S);

            //Console.WriteLine(result);

            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            _001_TwoSumsRefactored.twoSum(nums, target);

            Console.ReadLine();
        }

    }
}
