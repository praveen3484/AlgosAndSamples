using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;

namespace AlgosAndSamples
{
	public class HE_TimeDiff
	{
		public void DiffProcess()
		{
      File.Open("", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
			var R = Console.ReadLine();
      TimeSpan rt = TimeSpan.Parse(R); 
      var N = Convert.ToInt32(Console.ReadLine());
			string[] P = new string[N];
			for (int i = 0; i < N; i++)
			{
				P[i] = Console.ReadLine().Trim();
        ShowMessage(P[i], rt);
			}
		}
    static void ShowMessage(string m, TimeSpan rt)
    {
      if (string.IsNullOrWhiteSpace(m)) ;
      else
      {

        var mt = TimeSpan.Parse(m);
        var timeDiff = rt - mt;
        if (timeDiff.Ticks == 0) Console.WriteLine("now");
        else if (timeDiff.TotalSeconds == 1) Console.WriteLine(timeDiff.TotalSeconds + " second ago");
        else if (timeDiff.TotalSeconds < 60 && timeDiff.TotalSeconds > 1) Console.WriteLine(timeDiff.TotalSeconds + " seconds ago");
        else if (timeDiff.TotalMinutes == 1) Console.WriteLine(timeDiff.TotalMinutes + " minute ago");
        else if (timeDiff.TotalMinutes > 1 && timeDiff.TotalMinutes < 60) Console.WriteLine(timeDiff.TotalMinutes + " minutes ago");
        else if (timeDiff.TotalHours == 1) Console.WriteLine(timeDiff.TotalHours + " hour ago");
        else if (timeDiff.TotalHours >= 1) Console.WriteLine(timeDiff.TotalHours + " hours ago");
      }
    }
  }
}
