using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode dummy = new ListNode(0);

            while (true)
            {
                if (l1 == null) break;
                dummy.next = new ListNode(l1.val);
                l1 = l1.next;
            }

            Console.ReadLine();
        }


    }
}
