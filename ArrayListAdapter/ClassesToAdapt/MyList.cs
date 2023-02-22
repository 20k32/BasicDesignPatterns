using System.Collections;
using System.Collections.Generic;

namespace ArrayListAdapter
{
    public class MyList<T> : IEnumerable<T>
    {
        public List<T> list { get; private set; } = null!;

        public int ElementCount => list.Count;

        public MyList()
        { }

        public void SetList(params T[] NewArray)
        {
            list = new List<T>(NewArray);
        }

        public void AddElement(T element)
        {
            list.Add(element);
        }

        public bool RemoveElement(T element)
        {
            return list.Remove(element);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < ElementCount; i++)
            {
                yield return list[i];
            }
        }
    }
}
