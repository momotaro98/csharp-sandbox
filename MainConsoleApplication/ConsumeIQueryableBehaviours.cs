using System;
using System.Linq;
using IQueryableBehaviours;

namespace MainConsoleApplication
{
    internal static partial class Program
    {
        internal static void ConsumeIQueryableBehaivours()
        {
            Console.WriteLine($"========== Start {nameof(UseMyEnumerable)} ==========");
            UseMyEnumerable();
            Console.WriteLine($"========== Start {nameof(UseMyQueryProvider)} ==========");
            UseMyQueryProvider();
        }
        
        private static void UseMyEnumerable()
        {
            var e = new MyEnumerable();
            var q2 = e.Where(x => x % 2 == 0);
            var q3 = q2.Select(x => x * x);
            foreach (var val in q3)
            {
                Console.WriteLine($"{val}");
            }
        }

        private static void UseMyQueryProvider()
        {
            var q1 = MyQueryProvider.CreateQueryable<int>();
            Console.WriteLine($"q1: {q1.Expression}");

            var q2 = q1.Where(x => x % 2 == 0);
            Console.WriteLine($"q2: {q2.Expression}");

            var q3 = q2.Select(x => x * x);
            Console.WriteLine($"q3: {q3.Expression}");
            
            // Executeメソッドがnullのみを返すのでこのforeachで"ランタイム"エラーとなる。
            // foreachのコメントアウトを外してもコンパイルは通る。
            //foreach (var val in q3) 
            //{
            //   Console.WriteLine($"{val}");
            //}
        }
    }
}