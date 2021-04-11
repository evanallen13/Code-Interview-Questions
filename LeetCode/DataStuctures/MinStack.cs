using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.DataStuctures
{
    public class MinStack
    {
        List<int> list;
        /** initialize your data structure here. */

        public MinStack()
        {
            list = new List<int>();
        }

        public void push(int x)
        {
            list.Add(x);
        }

        public void pop()
        {
            list.RemoveAt(list.Count - 1);
        }

        public int top()
        {
            return list[list.Count - 1];
        }

        public int getMin()
        {
            return list.Min();
        }
    
    }
}
