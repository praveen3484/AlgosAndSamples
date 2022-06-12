using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgosAndSamples
{
    class CheckifAllDigits
    {
        private static Regex regex = new Regex("^[0-9]+$", RegexOptions.Compiled);

        public void TestDigit()
        {
            Stopwatch stopwatch = new Stopwatch();
            string testNo = new Random().Next().ToString();
            int value;
            stopwatch.Start();
            for(int i =0; i< 1000000; i++)
            {
                int.TryParse(testNo, out value);
            }
            stopwatch.Stop();
            Console.WriteLine("tryParse: " + stopwatch.ElapsedMilliseconds);
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                IsAllDigits(testNo);
            }
            stopwatch.Stop();
            Console.WriteLine("IsAllDigits: " + stopwatch.ElapsedMilliseconds);

            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                regex.IsMatch(testNo);
            }
            stopwatch.Stop();
            Console.WriteLine("Regex: " + stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
        public static bool IsAllDigits(string str)
        {
            foreach(char c in str)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }
    }
}
/*
    You have an matrix, each row contains 0's followed by 1's. find the row with max no of 1's.
    m rows, n col

    0 0 0 1 1
    0 0 1 1 1 -> ans
    0 0 0 0 0
    0 0 0 1 1
*/

/*
    you have an arr. every ele appers twice except one element. find that ele which appears only once.

    1 3 5 5 9 1 9

    3
*/
