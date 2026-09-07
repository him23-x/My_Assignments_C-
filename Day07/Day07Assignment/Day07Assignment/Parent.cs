using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Assignment
{
    internal class Parent
    {
        #region properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region constructors
        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion

        #region methods
        public int Product()
        {
            return X * Y;
        }

        public virtual int Product1()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"X: {X} and Y: {Y}";
        }
        #endregion

    }
}
