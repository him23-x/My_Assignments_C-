using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment
{
    public class SortingAlgorithm<T>
    {
        public void Sort(T[] array, Comparison<T> comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int smallestIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparison(array[j], array[smallestIndex]) < 0)
                    {
                        smallestIndex = j;
                    }
                }

                T temp = array[i];
                array[i] = array[smallestIndex];
                array[smallestIndex] = temp;
            }
        }


        public void SortTwo(T[] array, Comparison<T> comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int largestIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparison(array[j], array[largestIndex]) < 0)
                    {
                        largestIndex = j;
                    }
                }

                T temp = array[i];
                array[i] = array[largestIndex];
                array[largestIndex] = temp;
            }
        }
    }
}
