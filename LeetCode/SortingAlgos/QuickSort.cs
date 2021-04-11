using System;
using System.Linq;

namespace LeetCode.SortingAlgos
{

    class QuickSort{

        public static int[] sort(int[] arr, int left, int right){
            
            if(left < right){

                int[] frag = arr[left..right].Concat(arr[right..4]).ToArray();

                foreach(int i in frag){
                    Console.Write(i);
                }

            }

            return arr;
        }
    }
}