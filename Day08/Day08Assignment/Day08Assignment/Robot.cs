using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Assignment
{
    public class Robot : IWalkable
    {
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walks using IWalkable.");
        }

        public void Walk()
        {
            Console.WriteLine("Robot's own Walk method.");
        }
    }
}
