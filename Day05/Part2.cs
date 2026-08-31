using System;

namespace Day05_Part2
{
    class Program
    {
        static void Main()
        {
            #region Problem1
            //int.TryParse(Console.ReadLine(),out int number);

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Problem2
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(number * i);
            //} 
            #endregion

            #region Problem3
            //int.TryParse(Console.ReadLine(), out int number);


            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Problem4
            //Console.Write("Enter the number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.Write("Enter the Power: ");
            //int.TryParse(Console.ReadLine(), out int power);


            //long result = 1;

            //for (int i = 1; i <= power; i++)
            //{
            //    result *= number;
            //}

            //Console.WriteLine(result); 
            #endregion

            #region Problem5
            //string text = Console.ReadLine();

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //} 
            #endregion

            #region Problem6
            //int.TryParse(Console.ReadLine(),out int number);
            //int reversed = 0;

            //if (number == 0)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}

            //while (number > 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine(reversed); 
            #endregion

            #region Problem7
            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = -1;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;

            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"Longest distance = {maxDistance}"); 
            #endregion

            #region Problem8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');

            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words)); 
            #endregion


        }
    }
}
