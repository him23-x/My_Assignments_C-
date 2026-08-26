using System;
using System.Linq;

namespace DepiDay04
{
    internal class Program
    {
        static void Main()
        {
            #region Problem1
            //int[] Arr = new int[3];
            //int[] Arr2 = new int[] { 1, 2, 3 };
            //int[] Arr3 = { 1, 2, 3 };

            //Console.WriteLine(Arr3[4]); 
            #endregion

            #region Problem2
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = arr1;

            //Console.WriteLine("Array 1: " + string.Join(",", arr1));
            //Console.WriteLine("Array 2: "+ string.Join(",", arr2));

            //Console.WriteLine("After Edit-------------------------");

            //arr2[0] = 900;

            //Console.WriteLine("Array 1: " + string.Join(",", arr1));
            //Console.WriteLine("Array 2: " + string.Join(",", arr2));




            //Deep Copy:
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = (int[])arr1.Clone();

            //Console.WriteLine("Array 1: " + string.Join(",", arr1));
            //Console.WriteLine("Array 2: " + string.Join(",", arr2));

            //Console.WriteLine("After Edit-------------------------");

            //arr2[0] = 900;

            //Console.WriteLine("Array 1: " + string.Join(",", arr1));
            //Console.WriteLine("Array 2: " + string.Join(",", arr2)); 
            #endregion

            #region Problem3
            //int[,] TwoDArray = new int[3, 3];
            //bool isConverted = false;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Grades {j + 1} of student {i + 1}: ");
            //        isConverted = int.TryParse(Console.ReadLine(), out TwoDArray[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Grade of Student {i + 1} in Subject {j+1}: {TwoDArray[i,j]}");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem4
            //int[] arr = { 1, 2, 3, 4 };
            //Console.WriteLine("Original Array: " + string.Join(",", arr));

            //Array.Sort(arr);
            //Console.WriteLine("Array after sorting: " + string.Join(",", arr));


            //Array.Reverse(arr);
            //Console.WriteLine("Array after reverse: " + string.Join(",", arr));


            //int index = Array.IndexOf(arr, 2);
            //Console.WriteLine("Index of element 2: " + index);


            //int[] NewArr = new int[4];
            //Array.Copy(arr, NewArr, arr.Length);

            //Console.WriteLine("Copied Array: " + string.Join(",", NewArr));

            //Array.Clear(NewArr, 0, 2);
            //Console.WriteLine("Array After Clear: " + string.Join(",", NewArr)); 
            #endregion

            #region Problem5
            //int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine();

            //foreach(int element in arr)
            //{
            //    Console.WriteLine(element);
            //}


            //Console.WriteLine();

            //int index = arr.Length;

            //while (index >= 0)
            //{
            //    index--;

            //    Console.WriteLine(arr[index]);
            //} 
            #endregion

            #region Problem6
            //bool isValidInput;
            //int result;

            //do
            //{
            //    Console.Write("Please enter Odd positive number: ");
            //    isValidInput = int.TryParse(Console.ReadLine(), out result);
            //}
            //while (result <= 0 || result % 2 == 0 || !isValidInput);
            //Console.WriteLine($"The result = {result}"); 
            #endregion

            #region Problem7
            //int[,] matrix = { { 1, 2, 3 }, { 1, 2, 3, }, { 1, 2, 3 } };

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem8
            //Console.Write("Enter Month number (from 1 to 12): ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //string monthName;

            //if (month == 1)
            //    monthName = "January";
            //else if (month == 2)
            //    monthName = "February";
            //else if (month == 3)
            //    monthName = "March";
            //else if (month == 4)
            //    monthName = "April";
            //else if (month == 5)
            //    monthName = "May";
            //else if (month == 6)
            //    monthName = "June";
            //else if (month == 7)
            //    monthName = "July";
            //else if (month == 8)
            //    monthName = "August";
            //else if (month == 9)
            //    monthName = "September";
            //else if (month == 10)
            //    monthName = "October";
            //else if (month == 11)
            //    monthName = "November";
            //else if (month == 12)
            //    monthName = "December";
            //else
            //    monthName = "Invalid month number";


            //Console.WriteLine("Month Name: " + monthName);




            //switch (month)
            //{
            //    case 1:
            //        monthName = "January";
            //        break;
            //    case 2:
            //        monthName = "February";
            //        break;
            //    case 3:
            //        monthName = "March";
            //        break;
            //    case 4:
            //        monthName = "April";
            //        break;
            //    case 5:
            //        monthName = "May";
            //        break;
            //    case 6:
            //        monthName = "June";
            //        break;
            //    case 7:
            //        monthName = "July";
            //        break;
            //    case 8:
            //        monthName = "August";
            //        break;
            //    case 9:
            //        monthName = "September";
            //        break;
            //    case 10:
            //        monthName = "October";
            //        break;
            //    case 11:
            //        monthName = "November";
            //        break;
            //    case 12:
            //        monthName = "December";
            //        break;
            //    default:
            //        monthName = "Invalid month number";
            //        break;
            //}

            //Console.WriteLine("Month Name: " + monthName); 
            #endregion

            #region Problem9
            //int[] arr = { 3, 2, 99, 2, 54, 1 };

            //Array.Sort(arr);
            //int index = Array.IndexOf(arr, 99);
            //Console.WriteLine(index);
            //int LastIndex = Array.LastIndexOf(arr, 2);
            //Console.WriteLine(LastIndex); 
            #endregion

            #region Problem10
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine(sum);
            //sum = 0;
            //foreach (int element in arr)
            //{
            //    sum += element;
            //}

            //Console.WriteLine(sum); 
            #endregion





        }
    }
}
