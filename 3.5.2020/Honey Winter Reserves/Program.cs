using System;

namespace Honey_Winter_Reserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double honey = double.Parse(Console.ReadLine());
            double sum = 0;

            while (true)
            {
            double newHoney = 0;
            string input = Console.ReadLine();
                if (input == "Winter has come")
                {
                    break;
                }
                for (int i = 1; i <= 6; i++)
                {
                    newHoney = double.Parse(Console.ReadLine());
                    sum += newHoney;
                }
                if (sum <= 0)
                {
                    Console.WriteLine($"{input} was banished for gluttony");
                }
            }
            if (honey > sum)
            {
                Console.WriteLine($"Hard Winter! Honey needed {honey - sum:f2}.");
            }
            else if(honey <= sum)
            {
                Console.WriteLine($"Well done! Honey surplus {sum - honey:f2}.");
            }
        }
    }
}
