using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _100_SameTree
    {
        public bool IsSameTree()
        {
            TreeNode p = new TreeNode(1);
            TreeNode q = new TreeNode(1);

            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            if (p.val == q.val)
                return true; // Remove this
               //return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

            return false;
        }

        private class TreeNode
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
}
