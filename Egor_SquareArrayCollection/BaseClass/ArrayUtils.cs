using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_SquareArrayCollection.BaseClass
{
    class ArrayUtils<T>
    {
        public static void Resize(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < (newSize > array.Length ? array.Length : newSize); i++)
                newArray[i] = array[i];

            array = newArray;
        }

        public static void Copy(T[] sourceArray, ref T[] targetArray, int length)
        {

            if (length <= 0)
            {
                targetArray = null;
                return;
            }

            targetArray = targetArray.Length < length ? new T[length] : targetArray;

            for (int i = 0; i < length; i++)
                targetArray[i] = sourceArray[i];

        }
    }
}
