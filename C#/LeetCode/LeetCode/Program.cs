using LeetCode.DataStuctures;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode headA = new ListNode(4);
            headA.next = new ListNode(1);
            headA.next.next = new ListNode(8);
            headA.next.next.next = new ListNode(4);
            headA.next.next.next.next = new ListNode(5);

            ListNode headB = new ListNode(5);
            headB.next = new ListNode(6);
            headB.next.next = new ListNode(1);
            headB.next.next.next = new ListNode(8);
            headB.next.next.next.next = new ListNode(4);
            headB.next.next.next.next.next = new ListNode(5);


            _0160_Intersection_of_Two_Linked_Lists.GetIntersectionNode(headA, headB);

            Console.ReadLine();

        }
    }
}