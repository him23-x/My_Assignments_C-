using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Assignment
{
    internal class Calculator
    {
        #region attributes
        private int num1 { get; set; }
        private string num2 { get; set; }
        public int num3 { get; set; }
        public double num4 { get; set; }
        public double num5 { get; set; }
        #endregion

        #region methods
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public double Sum(double num4, int num5)
        {
            return num4 + num5;
        } 
        #endregion

    }
}
