using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    static class Helper
    {
        public static T Max<T>(T X, T Y) where T : IComparable<T>
        {
            return X.CompareTo(Y) >= 0 ? X : Y;
        }
    }
}
