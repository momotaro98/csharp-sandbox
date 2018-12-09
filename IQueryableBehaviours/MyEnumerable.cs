using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IQueryableBehaviours
{
    public class MyEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return this.ReturnEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private IEnumerator<int> ReturnEnumerator()
        {
            var intArray = new int[] {4, 8, 7, 0, 6, 5, 1, 9, 3, 2};
            foreach (var val in intArray)
            {
                yield return val;
            }
        }
    }
}