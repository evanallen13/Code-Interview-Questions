using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class RemoveDuplicates
    {
        public static int removeDuplicates(int[] nums)
        {
            if (nums == null || nums.Length < 1) return 0;

            int result = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    result += 1;
                }
            }


            return result;
        }
    }
}
