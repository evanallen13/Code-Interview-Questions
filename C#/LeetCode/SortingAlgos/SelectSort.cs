using System;
using System.Linq;

namespace LeetCode.SortingAlgos
{
    class selectSort
    {

        public static int[] sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            int resultIndex = 0;

            while (arr.Length != 0)
            {
                int min = arr.Min();
                int index = Array.IndexOf(arr, min);
                int[] frag = new int[arr.Length - 1];

                for (int i = 0; i < index; i++){
                    frag[i] = arr[i];
                }

                for(int i = index + 1; i <= arr.Length - 1; i++){
                    frag[i - 1] = arr[i];
                }

                result[resultIndex] = min;
                resultIndex ++;
                arr = frag;
            }

            return result;
        }
    }
}