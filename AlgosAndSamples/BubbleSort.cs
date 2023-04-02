using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
	class BubbleSort : ProcessBase
	{
		/// <summary>
		/// Solution using two for loops
		/// </summary>
		public void Sort_1()
		{
			int[] arr = { 5, 1, 4, 2, 8 };
			bool swapped = false;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				swapped = false;
				for(int j = 0;j < arr.Length - i - 1; j++)
				{
					if (arr[j + 1] < arr[j])
					{
						// Swap.
						arr[i] = arr[i] + arr[i + 1];
						arr[i + 1] = arr[i] - arr[i + 1];
						arr[i] = arr[i] - arr[i + 1];
						swapped = true;
					}
				}
				// IF no two elements were
				// swapped by inner loop, then break
				if (!swapped)
					break;
			}
			Console.WriteLine(string.Join(" ", arr));
		}
		
		/// <summary>
		/// Sort using while loop
		/// </summary>
		public override void StartProcess()
		{
			int[] arr = { 5, 1, 4, 2, 8 };
			bool unSortedValueFound = false;
			bool sorted = false;
			while (!sorted)
			{
				for (int i = 0; i < arr.Length - 1; i++)
				{
					if (arr[i + 1] < arr[i])
					{
						arr[i] = arr[i] + arr[i + 1];
						arr[i + 1] = arr[i] - arr[i + 1];
						arr[i] = arr[i] - arr[i + 1];
						unSortedValueFound = true;
					}
				}
				if (!unSortedValueFound) sorted = true;
				unSortedValueFound = false;
			}
			Console.WriteLine(string.Join(" ", arr));
		}
	}
}
