using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DataStuctures
{
    class DoubleLinkedList
    {
        public int val;
        public DoubleLinkedList prev;
        public DoubleLinkedList next;
        public DoubleLinkedList(int val = 0, DoubleLinkedList prev = null, DoubleLinkedList next = null)
        {
            this.val = val;
            this.prev = prev;
            this.next = next;
        }
    }
}
