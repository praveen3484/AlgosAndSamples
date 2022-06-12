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
	}
}
