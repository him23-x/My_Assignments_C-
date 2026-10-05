using System;
using LibrarySystem.Contexts;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new LibraryDbContext();
            Console.WriteLine("LibraryDbContext is ready.");
        }
    }
}
