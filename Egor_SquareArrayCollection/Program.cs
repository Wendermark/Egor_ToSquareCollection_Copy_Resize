using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egor_SquareArrayCollection.BaseClass;

namespace Egor_SquareArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository<int>(5);

            for (int i = 1; i < repository.Length+1; i++)
                repository.Add(i);

            Console.WriteLine(repository);

            int[] standartArray = repository.Array;

            int[] secondArray = new int[10];

            IEnumerable<int> squareArray = ArrayUtils<int>.GetSquareCollection(standartArray);

            foreach (var item in squareArray)
                Console.WriteLine($"{item}");

            Console.WriteLine();

            ArrayUtils<int>.Copy(standartArray, ref secondArray, standartArray.Length);

            foreach (var item in secondArray)
                Console.WriteLine($"{item}");

            Console.WriteLine();

            ArrayUtils<int>.Resize(ref standartArray, 10);

            Console.WriteLine($"Новая длинна массива - {standartArray.Length}\n");

            Console.ReadKey();
        }
    }
}
