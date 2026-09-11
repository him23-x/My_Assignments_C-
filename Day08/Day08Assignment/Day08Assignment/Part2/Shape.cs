using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Assignment.Part2
{
    public class Shape : IComparable<Shape>
    {
        public string Name { get; set; }

        public double Area { get; set; }

        public Shape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape? other)
        {
            if (other == null)
                return 1;

            return Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return $"{Name} - Area: {Area}";
        }
    }
}
