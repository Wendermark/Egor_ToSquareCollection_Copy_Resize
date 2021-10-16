using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_SquareArrayCollection.BaseClass
{
    sealed class RepositoryUtils
    {
        public IEnumerable<int> GetSquare(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    yield return array[i] * array[i];
            }
        }
    }
}
