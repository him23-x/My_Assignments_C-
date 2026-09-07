using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Day07Assignment
{
    internal class Child : Parent
    {
        #region properties
        public int Z { get; set; } 
        #endregion

        #region Constructors
        public Child(int X, int Y, int Z) : base(X, Y)
        {
            this.Z = Z;
        }
        #endregion

        #region methods
        public new int Product()
        {
            return X * Y * Z;
        }

        public override int Product1()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"X: {X} and Y: {Y} and Z: {Z}";
        } 
        #endregion

    }
}
