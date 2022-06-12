using System;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AlgosAndSamples
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<Bench>();
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			//HE_TimeDiff he = new HE_TimeDiff();
			//he.DiffProcess();
			//Bench bench = new Bench();
			//bench.DateStringWithSubString();
			//var A = CommonHelper.IntArr(Console.ReadLine());
			//var P = CommonHelper.IntArr(Console.ReadLine());
			//var count = 0;
			//int min = Math.Min(A.Length, P.Length);
			//for (int i = 0; i < min; i++)
			//{
			//	if (A[i] == P[i])
			//		count++;
			//}
			//Console.WriteLine(count);
			#region Test support comments
			/// Uncomment to Test Singleton Pattern
			//SingletonDP.CheckSingleton();
			/// Uncomment for Testing Memento Pattern
			//MementoDP.CheckMemento();

			//BST bST = new BST();
			//bST.Run();
			HE_Monk_Array_Rotation_Solution obj = new HE_Monk_Array_Rotation_Solution();
			obj.Array_Rotation();
			//Console.ReadKey(true); 
			stopwatch.Stop();
			Console.WriteLine($"stopwatch.Elapsed time: {stopwatch.Elapsed.Hours}, {stopwatch.Elapsed.Minutes}, {stopwatch.Elapsed.Seconds}, {stopwatch.Elapsed.Milliseconds}");
			Console.WriteLine($"Duration: {stopwatch.Elapsed.Duration()}");
			Console.WriteLine($"Elapsed: {stopwatch.Elapsed}");

			#endregion
		}


		static void GuessValue1()
		{
			StudentA a = new StudentA();
			a.Marks = 20;
			a.Name = "First";
			var val = MulMarks(AddMarks(a), SubtractMarks(a));
		}
		static StudentA AddMarks(StudentA studentA)
		{
			studentA.Marks = studentA.Marks + 10;
			return studentA;
		}
		static StudentA SubtractMarks(StudentA studentA)
		{
			studentA.Marks = studentA.Marks - 10;
			return studentA;
		}
		static int MulMarks(StudentA studentA, StudentA b)
		{
			var v = studentA.Marks * b.Marks;
			return v;
		}
		class StudentA
		{
			public string Name { get; set; }
			public int Marks { get; set; }
		}
		public static int power(int n, int p)
		{
			if (n < 0 || p < 0)
				throw new Exception("n and p should be non-negative");
			else
			{
				//  return Math.Pow(n,p);
				int count = n;
				while (--p > 0)
				{
					count = count * n;
				}
				return count;
			}
		}
	}
	//[MemoryDiagnoser]
	public class Bench
	{
		private readonly string dateAsText = "02 04 2022";
		[Benchmark]
		public void DateStringWithSubString()
		{
			var dayAsText = dateAsText.Substring(0, 2);
			var monthAsText = dateAsText.Substring(3, 2);
			var YearAsText = dateAsText.Substring(6);
			Console.WriteLine($"Date is: {int.Parse(dayAsText)}/{int.Parse(monthAsText)}/{int.Parse(YearAsText)}");
		}
		//[Benchmark]
		public void DateStringWithSpanSplice()
		{
			ReadOnlySpan<char> dateAsSpan = dateAsText;
			var dayAsText = dateAsSpan.Slice(0, 2);
			var monthAsText = dateAsSpan.Slice(3, 2);
			var YearAsText = dateAsSpan.Slice(6);
			Console.WriteLine($"Date is: {int.Parse(dayAsText)}/{int.Parse(monthAsText)}/{int.Parse(YearAsText)}");
		}
	}
	class A
	{
		public A()
		{
			Console.WriteLine(this.GetType().Name + " called");
		}
		public void Display()
		{
			Console.WriteLine(this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name + " called");
		}
	}
	class B : A
	{
		public B()
		{
			Console.WriteLine(this.GetType().Name + " called");
		}
		public void Display()
		{
			Console.WriteLine(this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name + " called");
		}
	}
}
