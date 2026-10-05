using System;
using HealthCareSystem.Contexts;

namespace HealthCareSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new HealthCareDbContext();
            Console.WriteLine("HealthCareDbContext is ready.");
        }
    }
}
