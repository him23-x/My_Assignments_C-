using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Assignment
{
    internal class Circle:IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Shape area: {Area}");
        }
    }
}
