using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Assignment.Part2
{
    public class CircleSeries : IShapeSeries
    {
        private int radius = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            radius++;

            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }

        public void ResetSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }
    }
}
