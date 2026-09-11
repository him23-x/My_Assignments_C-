using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Assignment
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }
}
