using System;
using LeetCode.DataStuctures;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            TreeNode node = _108_ConvertToTree.SortedArrayToBST(arr);

            print(node);
        }

        public static void print(TreeNode node)
        {
            if (node == null) return;

            Console.WriteLine(node.val);

            print(node.left);
            print(node.right);
        }
    }
}
