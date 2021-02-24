using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode treeNode = new TreeNode(4);
            // Left 
            treeNode.left = new TreeNode(2);
            treeNode.left.left = new TreeNode(1);
            treeNode.left.right = new TreeNode(3);

            // Right 
            treeNode.right = new TreeNode(7);
            treeNode.right.left = new TreeNode(6);
            treeNode.right.right = new TreeNode(9);

           TreeNode result =  _226_InvertBinaryTree.InvertTree(treeNode);

            Console.ReadLine();
        }


    }
}
