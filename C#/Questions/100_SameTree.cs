﻿using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _100_SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {

            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            if (p.val == q.val)
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

            return false;
        }

    }
}
