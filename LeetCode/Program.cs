using System;
using static LeetCode.ListNode_Model;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] {9,9, 9 };

            int[] res = _066_PlusOne.PlusOne(digits);

            foreach(int num in res)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }

    }
}
