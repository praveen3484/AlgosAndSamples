using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgosAndSamples
{
	[MemoryDiagnoser]
	class DryRun : ProcessBase
	{
		public override void StartProcess()
		{
			var st = Console.ReadLine();
			// [-1,0,1,2,-1,-4]
			var nums = CommonHelper.StringToIntArray(st);
			ThreeSum(nums);
			Console.WriteLine();
		}
		[Benchmark]
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			IList<int> ls = null;
			IList<IList<int>> finalLs = new List<IList<int>>();
			for (int i = 0; i < nums.Length - 2; i++)
			{
				for (int j = i + 1; j < nums.Length - 1; j++)
				{
					for (int k = j + 1; k < nums.Length; k++)
					{
						if ((nums[i] + nums[j] + nums[k]) == 0)
						{
							var list = new List<int>() { nums[i], nums[j], nums[k] };
							list.Sort();

							if (!finalLs.Any(x => x[0] == list[0] && x[1] == list[1] && x[2] == list[2]))
								finalLs.Add(list);
						}
					}
				}
			}
			return finalLs;
		}
	}
}
