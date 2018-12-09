using System;
using System.Linq;
using IQueryableBehaviours;

namespace MainConsoleApplication
{
    internal static partial class Program
    {
        internal static void ConsumeIQueryableBehaivours()
        {
            UseMyProvider();
        }

        private static void UseMyProvider()
        {
            var q1 = MyProvider.CreateQueryable<int>();
            Console.Write("{0}\n", q1.Expression);

            var q2 = q1.Where(x => x > 10);
            Console.Write("{0}\n", q2.Expression);

            var q3 = q2.OrderBy(x => x);
            Console.Write("{0}\n", q3.Expression);

            var q4 = q3.Select(x => x * x);
            Console.Write("{0}\n", q4.Expression);
        }
    }
}