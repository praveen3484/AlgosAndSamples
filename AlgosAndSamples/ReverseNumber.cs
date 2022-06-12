using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
	public class ReverseNumberProgram
	{
		public static void ReverseNumber()
		{
			int input = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Reverse(input));
		}

		public static int Reverse(int input)
		{
			int reversed = 0;
			while (input != 0)
			{
				int rem = input % 10;
				reversed = (reversed * 10) + rem;
				input = input / 10;
			}
			return Math.Abs(reversed);
		}
	}
}
