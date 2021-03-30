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

            Console.WriteLine(ll.Get(1));

            // var node = ll.node;

            // while(node != null){
            //     Console.WriteLine(node.val);
            //     node = node.next;
            // }
        }


    }
}
