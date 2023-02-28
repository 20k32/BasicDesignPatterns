using System.Collections;
using System.Collections.Generic;

namespace ArrayListAdapter
{
    public class MyArray<T> : IEnumerable<T>
    {
        public T[] array { get; private set; } = null!;

        public int ElementCount => array.Length;

        public MyArray()
        { }

        public MyArray(int elementCount)
        {
            array = new T[elementCount];
        }

        public void SetArray(params T[] NewArray)
        {
            for (int i = 0; i < ElementCount; i++)
            {
                array[i] = NewArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < ElementCount; i++)
            {
                yield return array[i];
            }
        }
    }
}
