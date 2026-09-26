using System;

namespace Day10Assignment
{
    internal class Program
    {
        public static int CompareByLength(string first, string second)
        {
            return first.Length.CompareTo(second.Length);
        }


        static void Main()
        {
            #region Problem1
            //Employee[] employees =
            //    {
            //    new Employee("Ahmed", 65000m),
            //    new Employee("Bob", 45000m),
            //    new Employee("Mohammed", 85000m),
            //    new Employee("Ziena", 55000m)
            //};

            //SortingAlgorithm<Employee> sorter = new SortingAlgorithm<Employee>();

            //sorter.Sort(
            //    employees,
            //    (employee1, employee2) =>
            //        employee1.Salary.CompareTo(employee2.Salary)
            //);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region Problem2
            //int[] numbers = { 12, 5, 20, 3, 8, 15 };

            //SortingAlgorithm<int> sorter = new SortingAlgorithm<int>();

            //sorter.Sort(numbers, (x, y) => y.CompareTo(x));

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //} 
            #endregion

            #region Problem3
            //string[] words =
            //{
            //    "elephant",
            //    "cat",
            //    "computer",
            //    "sun",
            //    "apple"
            //};

            //SortingAlgorithm<string> sorter = new SortingAlgorithm<string>();

            //sorter.SortTwo(words, CompareByLength);

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion






        }
    }
}
