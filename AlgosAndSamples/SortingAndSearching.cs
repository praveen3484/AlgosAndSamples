using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
    public class SortingAndSearching
    {
        public void GetFirstDuplicateElementUnOptimized()
        {
            List<int> arr = new List<int>(){ 1, 2, 4, 5,8,7, 9 };
            List<int> tempArr = new List<int>();
            for (int i =0; i< arr.Count; i++)
            {
                if (i == 0 || !tempArr.Contains(arr[i]))
                {
                    tempArr.Add(arr[i]);
                    continue;
                }
                else if (i < arr.Count)
                {
                    Console.WriteLine($"First duplicate element is {arr[i]}");
                    break;
                }
                else if(i == arr.Count) Console.WriteLine("No duplicate element found");
            }
        }
    }
}
