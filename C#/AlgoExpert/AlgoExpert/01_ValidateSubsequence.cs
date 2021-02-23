using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    class _01_ValidateSubsequence
    {
		public static bool IsValidSubsequence()
		{
			List<int> array = new List<int>() { 1, 1, 1, 1, 1 };
			List<int> sequence = new List<int>() { 1, 1, 1, 1, 1 };

			int lastIndex = -1;

			foreach(var num in sequence)
            {
				var index = array.IndexOf(num);
				if (index == -1)
					return false;

				if (lastIndex < index)
					lastIndex = index;
            }


			return true;
		}
	}
}
