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
            var intArray = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (var val in intArray)
            {
                yield return val;
            }
        }
    }
}