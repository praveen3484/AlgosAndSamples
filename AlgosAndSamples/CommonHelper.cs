using System.Collections.Generic;
using System;
namespace AlgosAndSamples
{
	class CommonHelper
	{
		public static int[] IntArr(string input)
		{
			int[] arr = new int[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				arr[i] = int.TryParse(input[i].ToString(), out var x) ? x : 0;
			}
			return arr;
		}
		public static int[] StringToIntArray(string myNumbers)
		{
			List<int> myIntegers = new List<int>();
			Array.ForEach(myNumbers.Split(",".ToCharArray()), s =>
			{
				int currentInt;
				if (Int32.TryParse(s, out currentInt))
					myIntegers.Add(currentInt);
			});
			return myIntegers.ToArray();
		}
	}
}
