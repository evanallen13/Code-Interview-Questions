using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DataStuctures
{
    class ListNode_Load
    {

        public ListNode_Load(int[] array)
        {
            ListNode node = null;

            for (var i = array.length - 1; i >= 0; i--)
            {
                int val = array[i];
                var dummy = new ListNode(val);
                dummy.next = node;
                node = dummy;

            }

            return node;
        }
    }
}
