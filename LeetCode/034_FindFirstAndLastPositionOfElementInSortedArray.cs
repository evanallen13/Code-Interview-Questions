using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _034_FindFirstAndLastPositionOfElementInSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };

            int first = -1;
            int last = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if (first != -1)
                        last = i;
                    else
                    {
                        first = i;
                        last = i;
                    }

                }
            }



            return new int[] { first, last };
        }

    }
}
