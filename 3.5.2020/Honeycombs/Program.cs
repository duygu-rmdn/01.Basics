using System;

namespace Honeycombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int bee = int.Parse(Console.ReadLine());
            int flower = int.Parse(Console.ReadLine());

            double grams = bee * flower * 0.21;

            double honeyCombs = Math.Floor(grams / 100);
            double output = grams % 100;

            Console.WriteLine($"{honeyCombs} honeycombs filled.");
            Console.WriteLine($"{output:f2} grams of honey left.");
        }
    }
}
