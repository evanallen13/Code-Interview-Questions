using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ContaineDuplicate{

         public static bool ContainsDuplicate(int[] nums) {
        
             if(nums.Length <= 1) return true;
             Dictionary<int, int> dict = new Dictionary<int, int>();

            int l = 0;
            int r = nums.Length - 1;

            while(l < r){

                bool left = dict.ContainsKey(nums[l]);
                bool right = dict.ContainsKey(nums[r]);

                if(left || right)
                    return true;
                 
                dict.TryAdd(nums[l], 1);
                dict.TryAdd(nums[r], 1);

                foreach(KeyValuePair<int, int> item in dict){
                    Console.Write($"[{item.Key},{item.Value}]");
                }

                l++;
                r--;
            }

            return false;
        }
    }

}