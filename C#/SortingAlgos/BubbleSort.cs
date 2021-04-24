using System;

namespace LeetCode.SortingAlgos
{

    class BubbleSort{

        public static int[] sort(int[] arr){

            bool isSorted = false;
            while(!isSorted){
                isSorted = true;
                for(int i = 1; i < arr.Length; i++){

                    int curr = arr[i];
                    int prev = arr[i - 1];

                    if(curr < prev){
                        arr[i - 1] = curr;
                        arr[i] = prev;
                        isSorted = false;
                    }
                }
            }
            
            return arr;
        }
    }
}