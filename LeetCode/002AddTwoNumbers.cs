using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _002AddTwoNumbers
    {
        public static ListNode AddTwoNumbers( /*ListNode l1, ListNode l2 */)
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            List<int> l1List = new List<int>();
            List<int> l2List = new List<int>();

            while (true)
            {
                if (l1 == null && l2 == null) break;

                if (l1 != null)
                    l1List.Add(l1.val);
                    l1 = l1.next;

                if (l2 != null)
                    l2List.Add(l2.val);
                    l2 = l2.next;
            }


            return l1;
        }

        public class ListNode
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
}
