using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    class _01_ValidateSubsequence
    {
		public static bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			List<int> result = new List<int>();

			int seqIndex = 0;
			int arrayIndex = 0;

			while(arrayIndex <= array.Count - 1 && seqIndex <= sequence.Count - 1)
            {
				if(array[arrayIndex] == sequence[seqIndex])
                {
					result.Add(sequence[seqIndex]);
					seqIndex++;
                }
				arrayIndex++;
			}
			Console.WriteLine(sequence.Count == result.Count);
			return sequence.Count == result.Count;
		}
	}
}
