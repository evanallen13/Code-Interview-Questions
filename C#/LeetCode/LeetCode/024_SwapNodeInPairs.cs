using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _24_SwapNodesInPairs
    {
        public static ListNode SwapPairs()
        {
            ListNode head = new ListNode();

            if (head == null || head.next == null) return head;

            if (head == null) return head;

            int first = head.val;
            int second = head.next.val;

            head.val = second;
            head.next.val = first;

            //SwapPairs(head.next.next);

            return head;
        }


        public static void printNode(ListNode node, ref string str)
        {
            if (node == null) return;
            str += $"{node.val.ToString()},";
            printNode(node.next, ref str);
        }
    }

    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
