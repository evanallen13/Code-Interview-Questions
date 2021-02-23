using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _004_FindMedianSortedArrays
    {

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n = nums1.Length + nums2.Length;
            int[] merged = new int[n];

            int i = 0;
            int j = 0;
            int mergedIndex = 0;

            while (true)
            {
                if (i >= nums1.Length - 1 && j >= nums2.Length)
                {
                    break;
                }
                /// Num2 finished 
                else if (i <= nums1.Length - 1 || j >= nums2.Length)
                {
                    merged[mergedIndex] = nums1[i];

                    mergedIndex += 1;
                    i += 1;
                }
                /// Num1 finished 
                else if (j <= nums2.Length - 1 || i <= nums1.Length - 1)
                {
                    merged[mergedIndex] = nums2[j];

                    mergedIndex += 1;
                    j += 1;
                }

            }

            return merged.Average();
        }
    }
}
