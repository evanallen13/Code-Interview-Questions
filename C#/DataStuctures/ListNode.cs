﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DataStuctures
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            next = null;
        }

        public static void print(ListNode node){
            if(node == null) return;

            Console.WriteLine(node.val);

            print(node.next);
        }
    }
}
