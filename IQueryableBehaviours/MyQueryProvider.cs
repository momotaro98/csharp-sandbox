using System.Linq;
using System.Linq.Expressions;

namespace IQueryableBehaviours
{
    public class MyQueryProvider : QueryProvider
    {
        public override string GetQueryText(Expression expression)
        {
            return string.Empty;
        }

        public override object Execute(Expression expression)
        {
            // Linq to SQLやEntity Frameworkといった実際のLinq Providerは
            // このExecuteを独自に実装しExpression(式木)から実際のクエリ(SQL)
            // を対象のデータソースに対して発行する。
            return null;
        }

        public static IQueryable<T> CreateQueryable<T>()
        {
            return new Query<T>(new MyQueryProvider());
        }
    }
}