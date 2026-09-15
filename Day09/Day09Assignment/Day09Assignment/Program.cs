using System;
using System.Runtime.InteropServices;

namespace Day09Assignment
{
    class Program
    {
        #region Problem1
        //enum Weekdays:byte
        //{
        //    Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        //}
        #endregion

        #region Problem2
        //enum Grades:short
        //{
        //    A,
        //    B,
        //    C,
        //    D,
        //    F = -1
        //}

        #endregion

        #region Problem7
        //enum DefaultGender
        //{
        //    Male,
        //    Female
        //}

        //enum Gender : byte
        //{
        //    Male,
        //    Female
        //} 
        #endregion

        #region Problem9
        //enum Grades : byte
        //{
        //    A,
        //    B,
        //    C,
        //    D,
        //    F
        //} 
        #endregion

        #region Problem13
        struct Rectangle
        {
            public int Length { get; set; }
            public int Width { get; set; }

            public override string ToString()
            {
                return $"Length: {Length}, Width: {Width}";
            }
        }

        static void swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle t = new Rectangle();

            t.Width = r1.Width;
            t.Length = r1.Length;

            r1.Length = r2.Length;
            r1.Width = r2.Width;

            r2.Length = t.Length;
            r2.Width = t.Width;
        } 
        #endregion


        static void Main()
        {
            #region Problem1
            //Weekdays day;
            //for(int i = 1; i <= 7;i++)
            //{
            //    day = (Weekdays)i;
            //    Console.WriteLine(day);
            //} 
            #endregion

            #region Problem2
            //foreach(Grades g in Enum.GetValues<Grades>())
            //{
            //    Console.WriteLine($"{g} = {(short)g}");
            //} 
            #endregion

            #region Problem3
            //Person person1 = new Person
            //{
            //    Name = "Ahmed",
            //    Age = 25,
            //    Department = "Computer Science"
            //};

            //Person person2 = new Person
            //{
            //    Name = "Mahmoud",
            //    Age = 30,
            //    Department = "Business Administration"
            //};

            //person1.PrintDetails();
            //person2.PrintDetails(); 
            #endregion

            #region Problem4
            //Child child = new Child
            //{
            //    Salary = 50000
            //};

            //child.DisplaySalary(); 
            #endregion

            #region Problem5
            //Console.WriteLine(Utility.CalcPerimeter(2, 3)); 
            #endregion

            #region Problem6
            //ComplexNumber n1 = new ComplexNumber() { Real = 22.34, Imaginary = 98.2 };
            //ComplexNumber n2 = new ComplexNumber() { Real = 18.64, Imaginary = 45.98 };
            //ComplexNumber result = n1 * n2;
            //Console.WriteLine(result); 
            #endregion

            #region Problem7
            //Console.WriteLine($"Defaul enum size: {sizeof(DefaultGender)}");
            //Console.WriteLine($"Bytes enum size: {sizeof(Gender)}"); 
            #endregion

            #region Problem8
            //double celsius = 25;
            //double fahrenheit = 77;

            //double convertedToFahrenheit = Utility.CelsiusToFahrenheit(celsius);

            //double convertedToCelsius = Utility.FahrenheitToCelsius(fahrenheit);

            //Console.WriteLine($"{celsius}celsius = {convertedToFahrenheit}fahrenheit");
            //Console.WriteLine($"{fahrenheit}fahrenheit = {convertedToCelsius}celsius"); 
            #endregion

            #region Problem9
            //string UserInput = Console.ReadLine();

            //Grades G01;

            //Enum.TryParse(UserInput,true, out G01);

            //Console.WriteLine(G01); 
            #endregion

            #region Problem10
            //Employee[] employees =
            //{
            //    new Employee { Id = 1, Name = "Ahmed" },
            //    new Employee { Id = 2, Name = "Mohamed" },
            //    new Employee { Id = 3, Name = "Ali" }
            //};

            //Employee employeeToSearch = new Employee { Id = 3, Name = "Any Name" };

            //int x = Helper2<Employee>.SearchArray(employees, employeeToSearch);
            //Console.WriteLine(x); 
            #endregion

            #region Problem11
            //int greaterInt = Helper.Max(10, 25);
            //double greaterDouble = Helper.Max(3.14, 2.71);
            //string greaterString = Helper.Max("Apple", "Banana");

            //Console.WriteLine(greaterInt);
            //Console.WriteLine(greaterDouble);
            //Console.WriteLine(greaterString);   
            #endregion

            #region Problem12
            //int[] numbers = { 1, 2, 3, 2, 4, 2, 5 };
            //Helper2<int>.ReplaceArray(numbers, 2, 99);

            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region Problem13
            //Rectangle r1 = new Rectangle()
            //{
            //    Length = 10,
            //    Width = 20
            //};
            //Rectangle r2 = new Rectangle()
            //{
            //    Length = 30,
            //    Width = 40
            //};

            //swap(ref r1, ref r2);
            //Console.WriteLine($"Rectangle one: {r1}");
            //Console.WriteLine($"Rectangle one: {r2}"); 
            #endregion

            #region Problem15
            //Circle circle1 = new Circle(10, "Red");
            //Circle circle2 = new Circle(10, "Red");
            //Circle circle3 = new Circle(10, "Blue");

            //Console.WriteLine(circle1 == circle2);     
            //Console.WriteLine(circle1.Equals(circle2));
            //Console.WriteLine(circle1 == circle3);  
            //Console.WriteLine(circle1.Equals(circle3));

            //object boxedCircle = circle2;

            //Console.WriteLine(circle1.Equals(boxedCircle)); 
            #endregion

        }
    }
}
