using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int[] arr = new int[]{6,5,2};

            var node = LeetCode.DataStuctures.ListNode_Load.Load(arr);


            var dummy =  _203_RemoveLinkedListElement.RemoveElements(node, 5);

            while(dummy != null){
                Console.WriteLine(dummy.val);
                dummy = dummy.next;
            }
            
        }
    }
}
