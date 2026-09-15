using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    public static class GenericMethods
    {
        
        #region Problem1Part2
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] reversed = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }

            return reversed;
        }
        #endregion

        #region Problem3Part2
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (index1 < 0 || index1 >= array.Length ||
                index2 < 0 || index2 >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T temporary = array[index1];
            array[index1] = array[index2];
            array[index2] = temporary;
        }
        #endregion

        #region Problem4Part2
        public static T FindMaximum<T>(T[] array) where T : IComparable<T>
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 0)
                throw new InvalidOperationException("The array is empty.");

            T maximum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(maximum) > 0)
                {
                    maximum = array[i];
                }
            }

            return maximum;
        } 
        #endregion



    }

}
