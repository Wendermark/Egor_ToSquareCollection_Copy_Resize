using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_SquareArrayCollection.BaseClass
{
    class Repository<T>
    {
        public T[] Array { get; private set; }

        public int Length { get; private set; }

        public int Count { get; private set; } = 0;

        public Repository (int length)
        {
            Array = new T[length];
            Length = length;
        }

        public void Add(T element)
        {
            if (Count.Equals(Length))
            {
                T[] newArray = new T[Length * 2];

                for (int i = 0; i < Length; i++)
                    newArray[i] = Array[i];

                newArray[Count++] = element;

                Array = newArray;

                Length = newArray.Length;

                Console.WriteLine("Место в массиве закончилось, он был увеличен в 2 раза");
            }
            else
                Array[Count++] = element;

        }

        public T this[int index]
        {
            get
            {
                if (index < Length && index >= Count)
                    return Array[index];
                else
                    return Array[index];
            }
            set
            {
                if (index < Length && index >= 0)
                    Array[index] = value;
                else
                    Console.WriteLine("Index out of bounds");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Array)
                yield return item;
        }

        public override string ToString() => $"Репозиторий состоит из {Count} элементов и имеет длину {Length}";
    }
}
