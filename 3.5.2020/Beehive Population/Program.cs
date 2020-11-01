using System;

namespace Beehive_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingCount = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int count = startingCount;
            for (int i = 0; i < years; i++)
            {
                count += count / 10 * 2;
                if (years % 5 == 0)
                {
                    count -= count / 50 * 5;
                }
                count -= count / 20 * 2;

            }
            Console.WriteLine($"Beehive population: {count}");
        }
    }
}
