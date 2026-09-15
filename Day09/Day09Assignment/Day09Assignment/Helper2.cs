using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    static class Helper2<T>
    {
        public static int SearchArray(T[] Arr, T value)
        {
            for(int i = 0;i<Arr.Length;i++)
            {
                if (Arr[i].Equals(value))
                    return i;
            }
            return -1;
        }


        public static void ReplaceArray(T[] arr, T oldValue, T newValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(oldValue))
                {
                    arr[i] = newValue;
                }
            }
        }

    }
}
