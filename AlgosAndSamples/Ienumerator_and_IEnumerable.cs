using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace AlgosAndSamples
{
    class IEnumerator_And_IEnumerable
    {
        public IEnumerator_And_IEnumerable()
        {

        }
        public void Test()
        {
            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");
            IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;
            IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();
            iEnumerableMethodOne(iEnumerableOfString);
            iEnumeratorMethodOne(iEnumeratorOfString);
        }
        static void iEnumerableMethodOne(IEnumerable<string> i)
        {
            foreach (var str in i)
            {
                Console.WriteLine(str);
                if (str == "June")
                {
                    iEnumerableMethodTwo(i);
                }
            }
        }
        static void iEnumerableMethodTwo(IEnumerable<string> i)
        {
            foreach (var str in i)
            {
                Console.WriteLine(str);
            }
        }
        static void iEnumeratorMethodOne(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);

                if (i.Current == "June")
                {
                    iEnumeratorMethodTwo(i);
                }
            }
        }

        static void iEnumeratorMethodTwo(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
            }
        }
    }
}
