using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            // 
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            //
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            // 


            Console.WriteLine(_104_MaximumDepthOfABinaryTree.MaxDepth(root));

            Console.ReadLine();

        }
    }
}
