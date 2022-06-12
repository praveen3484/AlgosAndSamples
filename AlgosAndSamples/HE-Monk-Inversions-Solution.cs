using System;

namespace AlgosAndSamples
{
	public class HE_Monk_Inversions_Solution
	{
		/// <summary>
		/// The following solution is regarding to HackerEarth question regarding Inversions in an Array.
		/// Ref: https://www.hackerearth.com/practice/codemonk/  Monk and Inversions question
		/// </summary>
		public void CheckInversions()
		{
			var testCases = Convert.ToInt32(Console.ReadLine());
			int[] numOfInversions = new int[testCases];
			for (int t = 0; t < testCases; t++)
			{
				var size = Convert.ToInt32(Console.ReadLine());
				int inversion = 0;
				int[,] mat = new int[size, size];
				for (int i = 0; i < size; i++)
				{
					var str = Console.ReadLine();
					var arr = IntArr(str);
					for (int j = 0; j < size; j++)
					{
						mat[i, j] = arr[j];
					}
				}
				for (int i = 0; i < size; i++)
				{
					for (int j = 0; j < size; j++)
					{
						var item = mat[i, j];
						for (int k = i; k < size; k++)
						{
							for (int l = j; l < size; l++)
							{
								if (item > mat[k, l])
								{
									inversion++;
								}
							}
						}
					}
				}
				numOfInversions[t] = inversion;
			}
			Console.WriteLine("Inversion counts are:");
			for (int i = 0; i < testCases; i++)
			{
				Console.WriteLine(numOfInversions[i]);
			}
		}
		public int[] IntArr(string input)
		{
			return Array.ConvertAll(input.Split(" "), s => int.TryParse(s, out var x) ? x : -1);
		}
	}
}
