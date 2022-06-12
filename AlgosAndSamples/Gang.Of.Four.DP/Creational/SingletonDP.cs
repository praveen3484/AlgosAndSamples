using System;

namespace AlgosAndSamples.Gang.Of.Four.DP.Creational
{
	/// <summary>
	/// The 'Singleton' class
	/// </summary>
	public class SingletonDP
	{
		static SingletonDP instance;
		SingletonDP()
		{
		}
		public static SingletonDP Instance()
		{
			// Uses lazy initialization.
			// Note: this is not thread safe.
			if (instance == null)
			{
				instance = new SingletonDP();
			}
			return instance;
		}
		public static void CheckSingleton()
		{
			SingletonDP s1 = SingletonDP.Instance();
			SingletonDP s2 = SingletonDP.Instance();
			if (s1 == s2)
			{
				Console.WriteLine("Both objects are same");
			}
		}
	}
}
