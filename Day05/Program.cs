using System;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace DepiDay05
{
    class Program
    {

        #region Problem2
        //public static void TestDefensiveCode(int x, int y)
        //{
        //    do
        //    {
        //        bool isConverted1 = int.TryParse(Console.ReadLine(), out x);
        //        bool isConverted2 = int.TryParse(Console.ReadLine(), out y);

        //    } while (x < 0 && y <= 1);
        //} 
        #endregion

        #region Problem9
        //public static void SumAndMultiplyTwoNums(int x, int y, out int MultiplyResult, out int SumResult)
        //{
        //    MultiplyResult = x * y;
        //    SumResult = x + y;
        //} 
        #endregion

        #region Problem10
        //public static void PrintRepeated(String text, int times = 5)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine(text);
        //    }
        //} 
        #endregion

        #region Problem13
        //public static int SumArray(params int[] numbers)
        //{
        //    int sum = 0;

        //    foreach (int number in numbers)
        //    {
        //        sum += number;
        //    }

        //    return sum;
        //} 
        #endregion


        static void Main()
        {

            #region Problem1
            //try
            //{
            //    int x, y;

            //    bool isConverted1 = int.TryParse(Console.ReadLine(), out x );
            //    bool isConverted2 = int.TryParse(Console.ReadLine(), out y);

            //    Console.WriteLine(x / y);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation Compelete");
            //} 
            #endregion

            #region Problem3
            //int? x = null;
            //int result = x ?? 0;

            //Console.WriteLine(x.HasValue);

            //try
            //{
            //    Console.WriteLine(x.Value);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Problem4
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //try
            //{
            //    Console.WriteLine(numbers[75]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: The array index is out of bounds.");
            //} 
            #endregion

            #region Problem5
            //int[,] numbers = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter value for [{i},{j}]: ");
            //        int.TryParse(Console.ReadLine(),out numbers[i, j]);
            //    }
            //}


            //Console.WriteLine("\nRow Sums:");

            //for (int i = 0; i < 3; i++)
            //{
            //    int sum = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        sum += numbers[i, j];
            //    }

            //    Console.WriteLine($"Row {i + 1} Sum = {sum}");
            //}

            //Console.WriteLine("\nColumn Sums:");

            //for (int j = 0; j < 3; j++)
            //{
            //    int sum = 0;

            //    for (int i = 0; i < 3; i++)
            //    {
            //        sum += numbers[i, j];
            //    }

            //    Console.WriteLine($"Column {j + 1} Sum = {sum}");
            //} 
            #endregion

            #region Problem6
            //int[][] numbers = new int[3][];


            //numbers[0] = new int[2];
            //numbers[1] = new int[3];
            //numbers[2] = new int[4];

            //int[] sum = { 0, 0, 0 };


            //for(int i = 0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine($"Enter {numbers.Length} values for row {i + 1}");

            //    for(int j = 0; j < numbers[i].Length;j++)
            //    {
            //        Console.Write($"Value {j + 1}: ");
            //        int.TryParse(Console.ReadLine(), out numbers[i][j]);
            //        sum[i] += numbers[i][j];
            //    }
            //}


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"\nValues of row {i + 1}: ");

            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j] + " ");
            //    }
            //} 
            #endregion

            #region Problem7

            //#nullable enable


            //            Console.Write("Do you want to enter your name? (y/n): ");
            //            string? answer = Console.ReadLine();

            //            string? name;

            //            if (answer?.ToLower() == "y")
            //            {
            //                Console.Write("Enter your name: ");
            //                name = Console.ReadLine();
            //            }
            //            else
            //            {
            //                name = null;
            //            }

            //            Console.WriteLine($"Name: {name ?? "No name provided"}");

            //            int nameLength = name!.Length;

            //            Console.WriteLine($"Name length: {nameLength}"); 
            #endregion

            #region Problem8
            ////boxing
            //int num = 5;
            //object obj;
            //obj = num;

            //Console.WriteLine(obj);

            ////unboxing
            //try
            //{
            //    num = (int)obj;
            //    Console.WriteLine(num);
            //}
            //catch(InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Problem9
            //SumAndMultiplyTwoNums(5, 3, out int MultiplyResult,out int SumResult);

            //Console.WriteLine(MultiplyResult);
            //Console.WriteLine(SumResult); 
            #endregion

            #region Problem10
            //PrintRepeated(text:"Hello",times:10);

            #endregion

            #region Problem11
            //int[]? numbers = null;

            //int? length = numbers?.Length;

            //Console.WriteLine(length); 
            #endregion

            #region Problem12
            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine()?.Trim().ToLower() ?? "";

            //int dayNumber;

            //switch (day)
            //{
            //    case "monday":
            //        dayNumber = 1;
            //        break;

            //    case "tuesday":
            //        dayNumber = 2;
            //        break;

            //    case "wednesday":
            //        dayNumber = 3;
            //        break;

            //    case "thursday":
            //        dayNumber = 4;
            //        break;

            //    case "friday":
            //        dayNumber = 5;
            //        break;

            //    case "saturday":
            //        dayNumber = 6;
            //        break;

            //    case "sunday":
            //        dayNumber = 7;
            //        break;

            //    default:
            //        dayNumber = 0;
            //        break;
            //}

            //if (dayNumber == 0)
            //{
            //    Console.WriteLine("Invalid day entered.");
            //}
            //else
            //{
            //    Console.WriteLine($"{day} corresponds to number {dayNumber}.");
            //} 
            #endregion

            #region Problem13
            //int sum1 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine($"Sum of individual values: {sum1}");

            //int[] numbers = { 10, 20, 30, 40 };
            //int sum2 = SumArray(numbers);
            //Console.WriteLine($"Sum of array values: {sum2}"); 
            #endregion

            Console.WriteLine("hi");
        }
    }
}
