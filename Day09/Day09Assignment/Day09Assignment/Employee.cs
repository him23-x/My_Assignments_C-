using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    class Employee
    {
        #region Property
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; }
        public Department DeptInfo { get; set; }
        #endregion


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary:{Salary}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee emp && emp.Id == Id ;
        }

    }
}
