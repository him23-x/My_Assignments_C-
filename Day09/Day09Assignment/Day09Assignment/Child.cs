using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    internal class Child:Parent
    {
        public sealed override int Salary { get; set; }

        public void DisplaySalary()
        {
            Console.WriteLine($"salary = {Salary}");
        }

    }
}
