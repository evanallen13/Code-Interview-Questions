using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.
    class TwoSum
    {
        public static int[] twoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int j = 0; j < nums.Length; j++)
            {
                int num = nums[j];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != j)
                    {
                        if (num + nums[i] == target)
                        {
                            result[0] = j;
                            result[1] = i;
                            isReturnResult = true;
                            return result;
                        }
                    }

                }
            }

            return result;
        }
    }
}
