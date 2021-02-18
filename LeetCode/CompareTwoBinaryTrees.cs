using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /*
  *  Given two binary trees, determine wheater
  *  they have the same inorder traversal 
  * 
  *        Tree 1                  Tree 2
  * 
  *           5                       3
  *          /  \                   /  \
  *        3     7                 1    6
  *       /      /                    /   \
  *      1      6                    5     7
  */
    class CompareTwoBinaryTrees
    {
        public static bool compareTwoBinaryTrees()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            TreeNode tree1 = new TreeNode(val: 5);
            tree1.left = new TreeNode(val: 3);
            tree1.left.left = new TreeNode(val: 1);
            tree1.right = new TreeNode(val: 7);
            tree1.right.left = new TreeNode(val: 6);

            TreeNode tree2 = new TreeNode(val: 3);
            tree2.left = new TreeNode(val: 1);
            tree2.right = new TreeNode(val: 6);
            tree2.right.left = new TreeNode(val: 5);
            tree2.right.right = new TreeNode(val: 7);

            inorder(tree1, ref list1);
            inorder(tree2, ref list2);

            return list1.Equals(list2);
        }

        public static void inorder(TreeNode root, ref List<int> list)
        {
            if (root == null) return;
            inorder(root.left, ref list);
            list.Add(root.val);
            inorder(root.right, ref list);
        }
    }


    public class TreeNode
    {
        public int val
        { get; set; }

        public TreeNode left
        { get; set; }

        public TreeNode right
        { get; set; }

        public TreeNode(int val)
        {
            this.val = val;
        }
    }
}
