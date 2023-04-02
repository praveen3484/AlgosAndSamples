using System;

namespace AlgosAndSamples
{
	class PrimeNumbers: ProcessBase
	{
		public override void StartProcess()
		{
			int endPoint = int.Parse(Console.ReadLine());
			if (endPoint > 0)
			{
				for (int i = 2; i <= endPoint; i++)
				{
					bool flag = false;
					for (int j = 2; j <= i; j++)
					{
						if (i % j == 0 && j != i) { flag = true; break; }
					}
					if (!flag) Console.Write(i + " ");
				}
			}
		}
	}
}
