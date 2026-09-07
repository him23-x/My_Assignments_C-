using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Assignment
{
    abstract class Shape
    {
        public virtual void Print()
        {
            Console.WriteLine("Drawing Shape");
        }
        public abstract double CalculateArea();
    }
}
