using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _001_TwoSumsRefactored
    {

        public static int[] twoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int searchNum = target - nums[i];

                if(Array.IndexOf(nums, searchNum) != -1 && 
                    Array.IndexOf(nums, searchNum) != nums[i])
                {
                    result[0] = i;
                    result[1] = Array.IndexOf(nums, searchNum);
                    return result;
                }
            }
            return result;
        }
    }
}
