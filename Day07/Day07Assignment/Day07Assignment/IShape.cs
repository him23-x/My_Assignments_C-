using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Assignment
{
    interface IShape
    {
        double Area { get; }
        void Draw();
        void PrintDetails();
    }
}
