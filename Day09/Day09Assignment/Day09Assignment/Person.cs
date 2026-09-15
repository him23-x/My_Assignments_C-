using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine();
        }
    }
}
