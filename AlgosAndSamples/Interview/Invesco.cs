using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples.Interview
{
	class Invesco : ProcessBase
	{
		/// <summary>
		/// Problem Statement: Given a string of repeated alphabets. Find the character that repeats the most no of times.
		/// Below is one solution.
		/// </summary>
		public override void StartProcess()
		{
			Dictionary<char, int> Val = new Dictionary<char, int>();
			string inputStr = "AADBCSRAPDDOUTDDBSS";
			foreach (char i in inputStr)
			{
				if (!Val.ContainsKey(i))
				{
					Val.Add(i, 1);
				}
				else
				{
					Val[i] = Val[i] + 1;
				}
			}
			char MaxChar = GetMaxVal(Val);
			Console.WriteLine(MaxChar);
		}
		static char GetMaxVal(Dictionary<char, int> Val)
		{
			int maxVal = int.MinValue;
			char MaxChar = '\0'; // There is nothing like char.Empty for a char. We need to set it to \0 which means empty value.
			foreach (var item in Val)
			{
				if (item.Value > maxVal)
				{
					maxVal = item.Value;
					MaxChar = item.Key;
				}
			}
			return MaxChar;
		}
	}
}
