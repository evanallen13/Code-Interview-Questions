using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return true;
        }
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
