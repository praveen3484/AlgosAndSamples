using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
    public class ReverseStringProgram
    {
        public string ReverseString(string inputString)
        {
            StringBuilder reverseString = new StringBuilder();
            if (!string.IsNullOrEmpty(inputString))
            {
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    reverseString.Append(inputString[i]);
                }                
            }
            return reverseString.ToString();
        }
    }
}
