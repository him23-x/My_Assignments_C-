using System;
using System.Xml.Linq;

namespace DepiDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //int x = 10;
            //int y = 20;
            //int sum = x + y;
            //Console.WriteLine(sum);

            /*
            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine(sum);*/

            //Ctrl + K, Ctrl + C  => Comment
            //Ctrl + K, Ctrl + U  => Uncomment 
            #endregion

            #region Problem2
            //int x = 10;
            //Console.WriteLine(x);

            ////Runtime error: that error occur during program execution and leads to exception
            ////example :
            //int X = 10;
            //int Y = 0;
            //Console.WriteLine(X / Y);
            ////Logical error : when program execute without any error but give error result
            ////example:
            //int length = 10;
            //int width = 5;

            //int area = length + width;
            //Console.WriteLine(area);
            #endregion

            #region Problem3
            //string FullName = "Ebrahim Sabry";
            //int age = 21;
            //decimal MonthlySalary = 50000.233m;
            //bool isStudent = true;

            ////Why we use naming convention: for many reasons :
            ////1- Inhance Readability    2- Easy Integration in Work team 
            ////3- professional standard 
            #endregion

            #region Problem4
            //Pointing Point1;
            //Pointing Point2;

            //Point1 = new Pointing();
            //Point2 = new Pointing();

            //Point1.x = 5;

            //Point2 = Point1;
            //Console.WriteLine(Point2.x); 



            //Value VS Ref: 
            //Value type : store the value in stack
            //Ref Type : store the refernce of object in heap

            #endregion

            #region Problem5
            //int x = 15, y = 4;

            //Console.WriteLine(x + y);
            //Console.WriteLine(x -  y);
            //Console.WriteLine(x * y);
            //Console.WriteLine(x / y);
            //Console.WriteLine(x % y);


            ////the Output of Console.WriteLine(a % b) : is  2 because :
            //// 2 /7 = 0.2 =>  0*7 = 0 => 2-0=2 => then the remainder of 2%7 = 2 
            /// 
            #endregion

            #region Problem6

            //int x = 4, y = 2;

            //Console.WriteLine(x > 10 && y > 10);

            //bool IsXEven = x % 2 == 0;
            //bool IsYEven = y % 2 == 0;

            //Console.WriteLine(IsXEven && IsYEven);



            //Difference Between && VS &: 
            // && (Logical AND): Used with Boolean expressions
            // It returns true only if both conditions are true
            //& (Bitwise AND): Used to compare individual bits of integer values 
            #endregion

            #region Problem7
            //Console.WriteLine("Enter a Number: ");

            //double Number = double.Parse(Console.ReadLine());

            //int ExplicitResult = (int)Number;
            //Console.WriteLine(ExplicitResult);

            ////Why is explicit casting required: Because converting
            ////a double to an int may cause data loss 
            #endregion.

            #region Problem8
            //Console.WriteLine("Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //bool isValidAge = age > 0;
            //Console.WriteLine(isValidAge);

            //What exception might occur :
            //If we use double.Parse()
            //and the user enters an invalid value, a FormatException may occur.
            // we can handle exceptions usning try catch 
            #endregion

            #region Problem9
            //int x = 10;

            ////prefix
            //Console.WriteLine(++x);// output = 11, x= 11
            //Console.WriteLine(--x);// output = 10, x = 10

            ////postfix
            //Console.WriteLine(x++);// output = 10, x= 11
            //Console.WriteLine(x--);// output = 11, x = 10



            ////the value of x after execution is 7 
            #endregion

        }
    }
}
