using System;

namespace dfdfdf
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingCount = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int count = startingCount;
            int diis = 0;
            for (int i = 1; i <= years; i++)
            {
                count += count / 10 * 2;
                if (i % 5 == 0)
                {
                    diis = count / 50 * 5;
                    count -= diis;
                }
                count -= count / 20 * 2;
            }
            Console.WriteLine($"Beehive population: {count}");

        }
    }
}
