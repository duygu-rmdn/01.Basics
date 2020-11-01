using System;

namespace Account_Balanse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 1;
            double totalBalanse = 0;
            while (n >= output)
            {
                double increase = double.Parse(Console.ReadLine());
                if (increase <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {increase:f2}");
                output++;
                totalBalanse += increase;
            }
            Console.WriteLine($"Total: {totalBalanse:f2} ");
        }
    }
}
