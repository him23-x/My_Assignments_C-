using System;
using System.Collections.Generic;


namespace Day1LinqTask
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Problem1
            //var myInt = 10;
            //var myString = "Hello";
            //var myDouble = 3.14;
            //var myBool = true;
            //var myArray = new int[] { 1, 2, 3, 4, 5 };

            //object[] variables =
            //{
            //    myInt,
            //    myString,
            //    myDouble,
            //    myBool,
            //    myArray
            //};

            //foreach (object variable in variables)
            //{
            //    Console.WriteLine(variable.GetType());
            //} 
            #endregion

            #region Problem2
            //// Explicit types
            //int age = 25;
            //string name = "Ebrahim";
            //double salary = 5000.50;
            //bool isStudent = true;

            //// Using var
            //var age2 = 25;
            //var name2 = "Ebrahim";
            //var salary2 = 5000.50;
            //var isStudent2 = true;

            //// The result is exactly the same at compile time because
            //// the compiler infers the type of each variable from its assigned value.
            //// Therefore:
            //// age2       => int
            //// name2      -> string
            //// salary2    -> double
            //// isStudent2 -> bool
            ////
            //// 'var' is only a shorthand for the programmer;
            //// it does NOT make the variable dynamically typed. 
            #endregion

            #region Problem3
            //var Products = new { Name = "Shambow", Price = 35.99, Quantity = 22 };
            //Console.WriteLine(Products.Name);
            //Console.WriteLine(Products.Price);
            //Console.WriteLine(Products.Quantity); 
            #endregion

            #region Problem4
            //var Students = new[]
            //{
            //    new{Name = "Ahmed",Grade = 85 },
            //    new{Name = "Mohammed",Grade = 79 },
            //    new{Name = "Hassan",Grade = 44 }
            //};

            //foreach(var student in Students)
            //{
            //    Console.WriteLine($"{student.Name}={student.Grade},");
            //} 
            #endregion

            #region Problem5
            //Console.WriteLine("madam".IsPalindrome());  
            //Console.WriteLine("level".IsPalindrome());  
            //Console.WriteLine("hello".IsPalindrome());  
            //Console.WriteLine("world".IsPalindrome()); 
            #endregion

            #region Problem6
            //Console.WriteLine(7.IsPrime()); 
            //Console.WriteLine(10.IsPrime());
            //Console.WriteLine(13.IsPrime());
            //Console.WriteLine(1.IsPrime()); 
            //Console.WriteLine(2.IsPrime());  
            #endregion

            #region Problem7
            //List<string> Employee = new List<string>() { "Ahmed", "Ali", "Hima" };

            //Employee.Add("Hamada");
            //Employee.Remove("Ali");
            //Console.WriteLine(Employee.Find(n => n == "Hima"));
            //foreach (string s in Employee)
            //{
            //    Console.WriteLine(s);
            //} 
            #endregion

            #region Problem8
            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee { Name = "Ahmed", Salary = 5000 },
            //    new Employee { Name = "Ali", Salary = 8000 },
            //    new Employee { Name = "Omar", Salary = 6000 },
            //    new Employee { Name = "Youssef", Salary = 10000 }
            //};

            //double givenSalary = 7000;

            //foreach (Employee employee in employees)
            //{
            //    if (employee.Salary > givenSalary)
            //    {
            //        Console.WriteLine(
            //            $"Name: {employee.Name}, Salary: {employee.Salary}");
            //    }
            //} 
            #endregion

        }
    }
}
