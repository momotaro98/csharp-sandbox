using System;

using CastBehaviors;

namespace MainConsoleApplication
{
    internal static partial class Program
    {
        private static readonly bool good = false;
        private static readonly bool bad = true;
        
        internal static void RunCastBehaviors()
        {
            RunCorrectCast();
            RunWrongCast();
        }
        
        private static void RunCorrectCast()
        {
            if (Factory.CreateParent(good) is SampleGoodChild c)
            {
                Console.WriteLine($"{nameof(c.ItemB)} is {c.ItemB}");
            }
            else
            {
                Console.WriteLine("Cast is failed");
            }
            
        }

        private static void RunWrongCast()
        {
            if (Factory.CreateParent(bad) is SampleGoodChild c)
            {
                Console.WriteLine($"{nameof(c.ItemB)} is {c.ItemB}");
            }
            else
            {
                Console.WriteLine("Cast is failed");
            }
        }
    }
}