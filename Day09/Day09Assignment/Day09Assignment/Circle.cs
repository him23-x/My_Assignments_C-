using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    class Circle
    {
        public double Radius { get; }
        public string Color { get; }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public static bool operator ==(Circle left, Circle right)
        {
            return left.Radius == right.Radius &&
                   left.Color == right.Color;
        }

        public static bool operator !=(Circle left, Circle right)
        {
            return !(left == right);
        }

        public bool Equals(Circle other)
        {
            return Radius == other.Radius &&
                   Color == other.Color;
        }
    }
}