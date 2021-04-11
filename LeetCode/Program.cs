using System;
using LeetCode.DataStuctures;
using LeetCode.Questions;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] nums = new int[]{1,2,3,4,5};
            int target = 5;

           int[] res = _001_TwoSums2.twoSum(nums, target);

           foreach(int i in res){
               Console.Write(i);
           }
        }
    }
}
