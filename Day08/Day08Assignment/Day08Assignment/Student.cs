using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08Assignment
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Address Address { get; set; }

       
        public Student(int id, string name, double grade, Address address)
        {
            Id = id;
            Name = name;
            Grade = grade;
            Address = address;
        }

        
        public Student(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            Grade = student.Grade;

            Address = new Address(student.Address.City);
        }
    }
}
