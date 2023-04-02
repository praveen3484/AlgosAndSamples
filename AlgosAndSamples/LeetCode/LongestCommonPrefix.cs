using System;

namespace AlgosAndSamples.LeetCode
{
	class LongestCommonPrefix : ProcessBase
	{
		public override void StartProcess()
		{
			var st = Console.ReadLine(); // pass: flower,flow,flight
			var strs = st.Split(',');
			var val = GetLongestCommonPrefix(strs);
			Console.WriteLine(val);
		}
		public string GetLongestCommonPrefix(string[] strs)
		{
			string minStr = MinStr(strs);
			int inc = 0; bool flag = true;
			while (flag && inc < minStr.Length)
			{
				for (int j = 0; j < strs.Length; j++)
				{
					if (minStr[inc] == strs[j][inc]) continue;
					else flag = false;
				}
				if (flag) { inc++; }
			}
			return minStr.Substring(0, inc);
		}
		private string MinStr(string[] strs)
		{
			string min = strs[0];
			for (int i = 0; i < strs.Length; i++)
			{
				if (strs[i].Length < min.Length)
					min = strs[i];
			}
			return min;
		}
	}
}
