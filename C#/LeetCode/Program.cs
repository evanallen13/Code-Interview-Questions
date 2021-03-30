using System;
using LeetCode.DataStuctures;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList ll = new MyLinkedList();

            ll.AddAtHead(2);
            ll.AddAtHead(1);

            ll.AddAtTail(69);

            ll.AddAtIndex(1, 75);

            var node = ll.node;

            while(node != null){
                Console.WriteLine(node.val);
                node = node.next;
            }
        }


    }
}
