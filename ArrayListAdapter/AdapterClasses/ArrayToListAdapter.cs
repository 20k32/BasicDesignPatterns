using System.Linq;
using System.Collections.Generic;

namespace ArrayListAdapter
{
    public static class ArrayToListAdapter
    {
        public static MyList<T> Adapt<T>(this MyArray<T> array)
        {
            MyList<T> result = new MyList<T>();
            result.SetList(array.array);
            return result;
        }
    }

    public static class ListToArrayAdapter
    {
        public static MyArray<T> Adapt<T>(this MyList<T> list, int arraySize)
        {
            MyArray<T> array = new MyArray<T>(arraySize);

            int Size = arraySize > list.ElementCount ? list.ElementCount : arraySize;

            for (int i = 0; i < Size; i++)
            {
                array.array[i] = list.list[i];
            }
            return array;
        }
    }
}
