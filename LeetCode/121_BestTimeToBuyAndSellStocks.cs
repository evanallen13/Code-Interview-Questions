using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode
{
    class _121_BestTimeToBuyAndSellStocks
    {
        public static int MaxProfit(int[] prices)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int maxProfit = 0;

            int min = prices[0];
            int max = prices[prices.Length - 1];

            int start = 0;
            int end = prices.Length - 1;

           while(start <= end)
            {
                min =  min > prices[start] ? prices[start] : min;
                max = max < prices[end] ? max = prices[end] : max;

                maxProfit = max - min;


                start = start + 1;
                end = end - 1;
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            return maxProfit;
        }

    }
}
