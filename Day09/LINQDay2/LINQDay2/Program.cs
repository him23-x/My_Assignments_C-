using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using day10_G01;
using static day10_G01.ListGenerators;


namespace LINQDay2
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators 
            //var ProductsIsOutOfStock = ProductList.Where((p) => p.UnitsInStock == 0);
            //foreach(var Product in ProductsIsOutOfStock)
            //{
            //    Console.WriteLine(Product);
            //}


            //var PriceMoreThan1000 = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //Console.WriteLine(PriceMoreThan1000?.ProductName ?? "NULL");

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where((A) => A > 5).ElementAt(1);
            //Console.WriteLine(result); 
            #endregion

            #region LINQ - Aggregate Operators

            #region Problem1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where((N) => N % 2 == 0).Count();
            //Console.WriteLine(res); 
            #endregion

            #region Problem2
            //var Customers = CustomerList.Select((C) => new { C.Id, C.Name, NOrders = C.Orders.Count() });
            //foreach(var Customer in Customers)
            //{
            //    Console.WriteLine(Customer);
            //} 
            #endregion

            #region Problem3
            //var ListOfCategories = ProductList.GroupBy((P) => P.Category)
            //    .Select((G) => new { Category = G.Key, NumberOfProducts = G.Count() });

            //foreach (var Category in ListOfCategories)
            //{
            //    Console.WriteLine(Category);
            //} 
            #endregion

            #region Problem4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int res = Arr.Sum();
            //Console.WriteLine(res); 
            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region Problem1
            //var OrderByName = ProductList.OrderBy((p) => p.ProductName);
            //foreach(var Order in OrderByName)
            //{
            //    Console.WriteLine(Order);
            //} 
            #endregion

            #region Problem2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy((Word) => Word, new CaseInsensitiveComparer());
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem3
            //var ProductOrderedByDesc = ProductList.OrderByDescending((P) => P.UnitsInStock);
            //foreach(var item in ProductOrderedByDesc)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.OrderBy(w => w.Length)
            //                .ThenBy(w => w);

            //foreach (var word in result)
            //    Console.WriteLine(word); 
            #endregion

            #region Problem5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res = words.OrderBy((word) => word.Length)
            //    .ThenBy((word) => word, new CaseInsensitiveComparer());

            //foreach(var word in words)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region Problem6
            //var res = ProductList.OrderBy(P => P.Category)
            //    .ThenByDescending(P => P.UnitPrice);

            //foreach(var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w.Length)
            //                .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //    Console.WriteLine(word); 
            #endregion

            #region Problem8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(w => w[1] == 'i')
            //                .Reverse();

            //foreach (var word in result)
            //    Console.WriteLine(word); 
            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region Problem1
            //var ProductsName = ProductList.Select(P => P.ProductName);
            //foreach(var Product in ProductsName)
            //{
            //    Console.WriteLine(Product);
            //} 
            #endregion

            #region Problem2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var item in result)
            //    Console.WriteLine($"Uppercase: {item.Upper}, Lowercase: {item.Lower}"); 
            #endregion

            #region Problem3
            //var Products = ProductList.Select((P) => new { 
            //    P.ProductID, P.ProductName, Price = P.UnitPrice 
            //});

            //foreach(var Product in Products)
            //    Console.WriteLine(Product); 
            #endregion

            #region Problem4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Select((N, I) => new { Number = N, InPlace = N == I });
            //foreach (var item in res)
            //    Console.WriteLine($"{item.Number}: {item.InPlace}"); 
            #endregion

            #region Problem5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select new { a, b };

            //foreach (var pair in res)
            //    Console.WriteLine($"{pair.a} is less than {pair.b}"); 
            #endregion

            #region Problem6
            //var orders = from c in CustomerList
            //             from o in c.Orders
            //             where o.Total < 500
            //             select new { o.Id, o.Total };

            //var orders = CustomerList.Select((C) => new
            //{
            //    C.Id,
            //    Orders = C.Orders.Where(o => o.Total < 500)
            //});

            //foreach (var order in orders)
            //    Console.WriteLine(order); 
            #endregion

            #region Problem7
            //var res = CustomerList.SelectMany(c => c.Orders)
            //    .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var c in res)
            //{
            //    Console.WriteLine(c);
            //} 
            #endregion



            #endregion

            #region LINQ - Aggregate Operators

            #endregion





        }
    }
}
