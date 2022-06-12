using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
    /// <summary>
    /// When applied to a class, the sealed modifier prevents other classes from inheriting from it.
    /// </summary>
    public sealed class SealedClassesdemo
    {
        public void TestMethodA()
        {
            Console.Write("Method from sealed class called!");
        }
    }

    ///Attempting the following will give compile time error
    //public class ChildOfSealedClass : SealedClassesdemo { }


    class X
    {
        protected virtual void F() { Console.WriteLine("X.F"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
    }
    class Y : X
    {
        sealed protected override void F() { Console.WriteLine("Y.F"); }
        protected override void F2() { Console.WriteLine("Y.F2"); }

    }
    class Z: Y
    {
        /// <summary>
        /// Attempting to override F from Y would give a compile time error
        /// as we cannot override a sealed method
        /// </summary>
        //protected override void F() { Console.WriteLine("Z.F"); }
        protected override void F2() { Console.WriteLine("Z.f2"); }
    }

    /// <summary>
    /// Abstract class cannot be sealed or static
    /// It is an error to use the abstract modifier with a sealed class,
    /// because an abstract class must be inherited by a class that provides an implementation of the abstract methods or properties.
    /// </summary>
    //abstract sealed class A { }
}
