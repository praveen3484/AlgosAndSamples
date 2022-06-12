using System;
using System.Text;

namespace AlgosAndSamples
{
	public class HE_Monk_Array_Rotation_Solution
	{
		public void Array_Rotation()
		{
			var testCases = Convert.ToInt32(Console.ReadLine());
			for (int j = 0; j < testCases; j++)
			{
				var input = Console.ReadLine().Split(" ");
				var len = Convert.ToInt32(input[0]);
				var rotation = Convert.ToInt32(input[1]);
				var index = len - (rotation % len);
				var arr = Console.ReadLine().Split(" ");
				// Use of StringBuilder is what made this query even more efficient. Bringing runtime from 2 to 0.162689 sec
				StringBuilder sb = new StringBuilder();
				for (var i = index; i < len; i++)
				{
					sb.Append(arr[i]);
					sb.Append(" ");
				}
				for (var i = 0; i < index; i++)
				{
					sb.Append(arr[i]);
					sb.Append(" ");
				}
				Console.WriteLine(sb.ToString());
			}
		}
		#region Other less efficient/less accurate solutions

		public void Array_Rotation2()
		{
			var testCases = Convert.ToInt32(Console.ReadLine());
			string[] resultArr; int len, k;
			for (int j = 0; j < testCases; j++)
			{
				var input = IntArr(Console.ReadLine());
				len = input[0];
				k = ((input[1] <= len)) ? input[1] : input[1] % len;
				var arr = Console.ReadLine().TrimEnd().Split(' ');

				resultArr = new string[len];
				if (k == len)
				{
				}
				else
				{
					for (var i = 0; i < len; i++)
					{
						if (i + k >= len)
						{
							resultArr[(i + k) - len] = arr[i];
						}
						else
						{
							resultArr[i + k] = arr[i];
						}
					}
				}
				foreach (var i in resultArr)
				{
					Console.Write(i + " ");
				}
				Console.WriteLine();
			}
		}
		public void Array_Rotation1()
		{
			var testCases = Convert.ToInt32(Console.ReadLine());
			var input = IntArr(Console.ReadLine());
			string[] resultArr;
			for (int j = 0; j < testCases; j++)
			{
				int len = Convert.ToInt32(input[0]);
				int k = Convert.ToInt32(input[1]);
				var inputArr = Console.ReadLine();
				var arr = StringArr(inputArr);
				k = ((k <= len)) ? k : k % len;
				resultArr = new string[len];
				if (k == len)
				{
					resultArr = arr;
				}
				else
				{
					for (int i = 0; i < len; i++)
					{
						if (i + k >= len)
						{
							resultArr[(i + k) - len] = arr[i];
						}
						else
						{
							resultArr[i + k] = arr[i];
						}
					}
				}
				foreach (var i in resultArr)
				{
					Console.Write(i + " ");
				}

			}
		}
		public void Array_Rotation_Old()
		{
			var testCases = Convert.ToInt32(Console.ReadLine());
			var input = IntArr(Console.ReadLine());
			for (int i = 0; i < testCases; i++)
			{
				var n = input[0];
				var k = input[1];
				var inputArr = Console.ReadLine();
				var arr = IntArr(inputArr);

				int a = n % k;
				if (n == k)
				{
					Console.WriteLine("{0}", string.Join(" ", arr).TrimEnd());
					continue;
				}
				else if (n > k)
				{
					RotateArr(n, k, arr);
				}
				else
				{
					RotateArr(n, a, arr);
				}
				Console.WriteLine("{0}", string.Join(" ", arr).TrimEnd());

			}
		}
		private static void RotateArr(int n, int k, int[] arr)
		{
			for (int j = 0; j < k; j++)
			{
				var ini = arr[n - 1];
				for (int m = n - 1; m > 0; m--)
				{
					arr[m] = arr[m - 1];
				}
				arr[0] = ini;
			}
		}
		public static int[] IntArr(string input)
		{
			//return input.TrimEnd().Split(' ');
			return Array.ConvertAll(input.Split(" "), s => int.TryParse(s, out var x) ? x : -1);
		}
		public static string[] StringArr(string input)
		{
			return input.TrimEnd().Split(' ');
			//return Array.ConvertAll(input.Split(" "), s => int.TryParse(s, out var x) ? x : -1);
		} 
		#endregion
	}
}

//var timer = new Stopwatch();
//timer.Start();
//            Queue<int> que = new Queue<int>(arr);
//            Stack<int> stack = new Stack<int>();
//            while(k > 0)
//{
//                stack.Push(que.Dequeue());
//                que.Enqueue(stack.Pop());
//                k--;
//}
//Console.WriteLine("{0}", string.Join(" ", que.ToArray()).TrimEnd());
//Math.Round((arr[0]),)

//timer.Stop();
//TimeSpan timeTaken = timer.Elapsed;
//string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
//Console.WriteLine(foo);