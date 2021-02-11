using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _035_SearchInsertPosition
    {
        public static int searchInsert(int[] nums, int target)
        {
            int result = 0;
            int left = 0;
            int right = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                // First Index
                if(i == 0)
                {
                   if()
                }
                // Last Index
                else if (i + 1 > nums.Length - 1)
                {
                    Console.WriteLine(nums[i].ToString());
                }
                else
                {

                }
            }

            return result;
        }

    }
}
