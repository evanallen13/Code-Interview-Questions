using System;
using System.Collections;
using System.Collections.Generic;
using static LeetCode._203_RemoveLinkedListElement;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //string S = "vvvlo";

            //string result = _767_ReorganizeString.ReorganizeString(S);

            //Console.WriteLine(result);

            TreeNode root = new TreeNode(1);
            root = new TreeNode(1);
            // Left
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            // Right
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            List<int> leftList = new List<int>();
            List<int> leftRight = new List<int>();

            //_101_Symmetric_tree.IsSymmetric(root.left, root.right);
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);
            head.next.next.next.next.next.next = new ListNode(7);
            head.next.next.next.next.next.next.next = new ListNode(8);

            int val = 6;

            _203_RemoveLinkedListElement.RemoveElements(head, val);

            while (true)
            {
                if (head == null) break;
                Console.WriteLine(head.val);
                head = head.next;
            }

            Console.ReadLine();
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

    }
}
