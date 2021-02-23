using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _083_RemoveDuplicateFromSortedList
    {
        public static ListNode DeleteDuplicates(/*ListNode head*/)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);

            List<int> nums = new List<int>();

            while (true)
            {
                if (head == null)
                    break;
                if (head.next == null)
                    nums.Add(head.next.val);

                if (head.val == head.next.val)
                {
                    head.next = head.next.next;
                    head = head.next;
                }
                else
                {
                    nums.Add(head.next.val);
                    head = head.next;
                }

            }

            Console.WriteLine("hell0");
        }

        private class ListNode
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
