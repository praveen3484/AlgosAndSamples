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
			
			Bench bench = new Bench();
			bench.DateStringWithSubString();
			Process();
			stopwatch.Stop();
			Console.WriteLine($"stopwatch.Elapsed time: {stopwatch.Elapsed.Hours}, {stopwatch.Elapsed.Minutes}, {stopwatch.Elapsed.Seconds}, {stopwatch.Elapsed.Milliseconds}");
			Console.WriteLine($"Duration: {stopwatch.Elapsed.Duration()}");
			Console.WriteLine($"Elapsed: {stopwatch.Elapsed}");

		}
		static void Process()
		{
			Console.WriteLine($"Please enter the process you want to run:: ");
			foreach (var item in System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
				Console.WriteLine("FullyQualifiedName: " + item.Namespace + "." + item.Name);
			var fullyQualifiedName = Console.ReadLine();
			ProcessBase pb = GetProcessInstance(fullyQualifiedName);
			pb.StartProcess();
			#region Test support comments

			//HE_TimeDiff he = new HE_TimeDiff();
			//he.DiffProcess();
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
			/// Uncomment to Test Singleton Pattern
			//SingletonDP.CheckSingleton();
			/// Uncomment for Testing Memento Pattern
			//MementoDP.CheckMemento();

			//BST bST = new BST();
			//bST.Run();
			//HE_Monk_Array_Rotation_Solution obj = new HE_Monk_Array_Rotation_Solution();
			//obj.Array_Rotation();
			//Console.ReadKey(true); 
			//PrimeNumbers.PrintPrimeNumbers();
			#endregion
		}
		/// <summary>
		/// Returns object of the class that overrides ProcessBase class.
		/// Needs fullyQualifiedname (=Namespace.ClassName) of the class whose object needs to be created, as parameter. e.g. AlgosAndSamples.DryRun
		/// </summary>
		/// <param name="fullyQualifiedName">Namespace.ClassName</param>
		/// <returns></returns>
		static ProcessBase GetProcessInstance(string fullyQualifiedName)
		{
			// If the class is in the current Assembly then type != null.
			Type type = Type.GetType(fullyQualifiedName);
			if(type != null)
				return (ProcessBase)Activator.CreateInstance(type);
			//else check in each Assembly for this class.
			foreach(var asm in AppDomain.CurrentDomain.GetAssemblies())
			{
				type = asm.GetType(fullyQualifiedName);
				if(type != null)
					return (ProcessBase)Activator.CreateInstance(type);
			}
			return null;
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

	abstract class Component
	{
		public abstract string Name { get; set; }
		public abstract int Id { get; set; }
	}
	class Frame : Component
	{
		public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}

}
