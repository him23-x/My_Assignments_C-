    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Assignment.Part2
{
    public interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }

        void GetNextArea();

        void ResetSeries();
    }
}
