using LeetCode.DataStuctures;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(1);

            _083_RemoveDuplicateFromSortedList.DeleteDuplicates(head);

            Console.ReadLine();

        }
    }
}
