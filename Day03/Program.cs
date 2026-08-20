using System;
using System.Linq;
using System.Text;

namespace CsharpDay03
{
    class Program
    {
        //public static void print<T>(T str)
        //{
        //    Console.WriteLine(str);
        //}
        //public static void print(object obj)
        //{
        //    Console.WriteLine(obj);
        //}
        static void Main()
        {
            #region Problem1
            //Console.Write("Enter Your Number: ");
            //string UserInput = Console.ReadLine();
            //int X = 0, Y = 0;

            //try
            //{
            //    X = int.Parse(UserInput);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Y = Convert.ToInt32(UserInput);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine($"Convert Using Parse(): {X}, Convert Using Convert():{Y}"); 
            #endregion
            #region Question1
            //int.Parse() not handle null gives exception and app be crashed,
            //Convert.ToInt32() return 0 when handling the null 
            #endregion

            #region Problem2
            //Console.Write("Enter Number: ");
            //bool isConverted = int.TryParse(Console.ReadLine(), out int result);
            //if (isConverted)
            //{
            //    Console.WriteLine($"Your number is : {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Error, Please enter number");
            //}
            #endregion
            #region Question2
            //TryParse Recommended because it handle input without throw exception

            #endregion


            #region Problem3
            //object p1;

            //p1 = 10;
            //Console.WriteLine(p1.GetHashCode());

            //p1 = "ali";
            //Console.WriteLine(p1.GetHashCode());

            //p1 = 15.8;
            //Console.WriteLine(p1.GetHashCode()); 
            #endregion
            #region Question3
            //The real purpose of GetHashCode()
            //is to produce an integer hash value
            //that helps collections quickly locate objects. 
            #endregion


            #region Problem4
            //Point p1 = new Point();
            //p1.X = 10;
            //Point p2 = p1;
            //p1.X = 15;
            //Console.WriteLine(p2.X); 
            #endregion
            #region Question4
            //Reference equality means checking whether two reference variables point to
            //the same object in memory 
            #endregion


            #region Problem5
            string str = "Ahmed";
            Console.WriteLine(str.GetHashCode());
            str += "Hi Willy";
            Console.WriteLine(str.GetHashCode());
            #endregion
            #region Question5
            //string is immutable because its an array of characters
            //and array is fixed size 
            #endregion


            #region Problem6
            //StringBuilder strBuilder = new StringBuilder("Ahmed");
            //Console.WriteLine(strBuilder.GetHashCode());
            //strBuilder.Append("Hi Willy");
            //Console.WriteLine(strBuilder.GetHashCode()); 
            #endregion
            #region Question6
            //StringBuilder improves the efficiency of repeated string concatenation by using a mutable buffer
            //reducing the number of temporary string objects and memory allocations. 
            #endregion

            #region Question7
            //StringBuilder is faster because it's mutable
            //reducing the creation of temporary string objects
            //and unnecessary memory allocations during repeated modifications 
            #endregion.


            #region Problem8
            //Console.Write("Enter number one: ");
            //int.TryParse(Console.ReadLine(), out int Num1);

            //Console.Write("Enter number two: ");
            //int.TryParse(Console.ReadLine(), out int Num2);


            //string result;

            //result = "Sum of " + Num1 + " + " + Num2 + " = " + (Num1 + Num2);
            //Console.WriteLine(result);

            //result = string.Format("Sum of {0} + {1} = {2}", Num1, Num2, (Num1 + Num2));
            //Console.WriteLine(result);

            //result = $"Sum of {Num1} + {Num2} = {(Num1 + Num2)}";
            //Console.WriteLine(result); 
            #endregion
            #region Question8
            //string formatting method is most used is string interpolation
            //because it not create unused objects 
            #endregion


            #region Problem9
            //StringBuilder str = new StringBuilder();

            //str.Append("Ahmed Mohsen");
            //Console.WriteLine(str);
            //str.Replace("Mohsen", "Hisham");
            //Console.WriteLine(str);
            //str.Insert(0, "Hi: ");
            //Console.WriteLine(str);
            //str.Remove(10, 6);
            //Console.WriteLine(str);
            #endregion
            #region Question9
            //StringBuilder uses a mutable buffer
            //allowing frequent modifications without creating a new string object for every change. 
            #endregion






            //String Are Immutable










        }
    }
}
