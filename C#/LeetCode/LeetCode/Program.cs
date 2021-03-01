using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            Console.WriteLine(_101_SymmetricTree.IsSymmetric(root));

            Console.ReadLine();

        }
    }
}
