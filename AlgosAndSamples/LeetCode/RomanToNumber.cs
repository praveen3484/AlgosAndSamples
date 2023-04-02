using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples.LeetCode
{
	class RomanToNumber : ProcessBase
	{
		public override void StartProcess()
		{
			var roman = Console.ReadLine();
			var val = RomanToInt(roman);
			Console.WriteLine(val);
		}
		public int RomanToInt(string s)
		{
			Dictionary<char, int> kv = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
			int finalVal = 0, temp = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (kv.TryGetValue(s[i], out int val))
				{
					if (i + 1 < s.Length)
					{
						if (s[i] == 'I' && s[i + 1] == 'V') { temp = 4; i += 1; }
						else if (s[i] == 'I' && s[i + 1] == 'X') { temp = 9; i += 1; }
						else if (s[i] == 'X' && s[i + 1] == 'L') { temp = 40; i += 1; }
						else if (s[i] == 'X' && s[i + 1] == 'C') { temp = 90; i += 1; }
						else if (s[i] == 'C' && s[i + 1] == 'D') { temp = 400; i += 1; }
						else if (s[i] == 'C' && s[i + 1] == 'M') { temp = 900; i += 1; }
						else
						{
							temp = val;
						}
					}
					else
					{
						temp = val;
					}
					finalVal += temp;
				}
			}
			return finalVal;
		}

		public int RomanToIntOptimized(string s)
		{
			Dictionary<char, int> kv = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
			int finalVal = 0, temp = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (kv.TryGetValue(s[i], out int val))
				{
					if (i + 1 < s.Length)
					{
						if (kv[s[i + 1]] > val) { temp = kv[s[i + 1]] - val; i += 1; }
						else
						{
							temp = val;
						}
					}
					else
					{
						temp = val;
					}
					finalVal += temp;
				}
			}
			return finalVal;
		}
	}
}
