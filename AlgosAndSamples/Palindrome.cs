using System;
using System.Text;

namespace AlgosAndSamples
{
	public sealed class Palindrome
	{
		public bool IsPalindrome(string input)
		{
			string reversedString = GetReversed(input);
			bool isPalindrome;
			if (reversedString != input)
			{
				Console.WriteLine("Not a pallindrome");
				isPalindrome = false;
			}
			else
			{
				Console.WriteLine("Pallindrome");
				isPalindrome = true;
			}
			return isPalindrome;
		}
		private static string GetReversed(string input)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = input.Length - 1; i >= 0; i--)
			{
				sb.Append(input[i]);
			}
			return sb.ToString();
		}
	}
}
