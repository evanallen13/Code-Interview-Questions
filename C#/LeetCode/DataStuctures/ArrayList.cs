using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DataStuctures
{
    class ArrayList
    {
        private static int Capacity = 3;
        private int[] Array = new int[Capacity];
        public int Count = 0;


        public ArrayList()
        {

        }

        public void Push(int x)
        {
            if (Count + 1 >= Capacity)
            {
                Capacity += 3;
                int[] newArray = new int[Capacity];
                for(int i = 0; i < Array.Length; i++)
                {
                    newArray[i] = Array[i];
                }
                Array = newArray;
            }
            Array[Count] = x;
            Count++;
        }

        public int Pop()
        {
            int result = Array[Count - 1];
            Array[Count - 1] = 0;
            Count--;
            return result;
        }

        public int[] Get()
        {
            return Array[0..Count];
        }
    }
}
