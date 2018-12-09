using System.Linq;
using System.Linq.Expressions;

namespace IQueryableBehaviours
{
    public class MyProvider : QueryProvider
    {
        public override string GetQueryText(Expression expression)
        {
            return string.Empty;
        }

        public override object Execute(Expression expression)
        {
            return null;
        }

        public static IQueryable<T> CreateQueryable<T>()
        {
            return new Query<T>(new MyProvider());
        }
    }
}