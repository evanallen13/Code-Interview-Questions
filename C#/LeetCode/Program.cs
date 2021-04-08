using System;
using LeetCode.DataStuctures;
using LeetCode.SortingAlgos;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{1, 2, 3, 1};
            bool res = ContaineDuplicate.ContainsDuplicate(nums);

            Console.WriteLine(res);
        }
    }
}
