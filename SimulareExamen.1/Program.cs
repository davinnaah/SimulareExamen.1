using System;

namespace SimulareExamen._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int fact = Recursivitate.Fact(5);
            Console.WriteLine($"Fact({n}) = {fact}");
        }
    }
}
