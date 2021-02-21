using System;
using System.Collections.Generic;
using System.Text;
using static LeetCode.Program;

namespace LeetCode
{
    class _101_Symmetric_tree
    {
        public static bool IsSymmetric(TreeNode left, TreeNode right)
        {

            if (left == null || right == null) return false;
            if (left.val != right.val) return false;

            IsSymmetric(left.right, right.left);
            IsSymmetric(left.left, right.right);
            return true;

        }
    }
}
