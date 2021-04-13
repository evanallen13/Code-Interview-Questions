using System;
using LeetCode.DataStuctures;
using LeetCode.Questions;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{1};
            int target = 1;

            _034_FindFirstAndLastPositionOfElementInSortedArray.SearchRange(nums, target);
        }
    }
}
