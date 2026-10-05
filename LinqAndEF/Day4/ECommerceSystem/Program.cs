using System;
using ECommerceSystem.Contexts;

namespace ECommerceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new ECommerceDbContext();
            Console.WriteLine("ECommerceDbContext is ready.");
        }
    }
}
