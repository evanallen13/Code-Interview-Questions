using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _204_CountPrimes
    {
        public static int countPrimes(int n)
        {
            int result = 0;

            for(int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                    result += 1;
                
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
