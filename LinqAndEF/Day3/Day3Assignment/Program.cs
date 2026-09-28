using System;
using BookstoreSystem.Contexts;

namespace BookstoreSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using var context = new BookstoreDbContext();
            Console.WriteLine("BookstoreDbContext is ready.");
        }
    }
}
