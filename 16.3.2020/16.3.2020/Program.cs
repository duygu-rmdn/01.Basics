using System;

namespace _16._3._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangle = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double totalOne = rectangle * (lenght + 0.60);
            double totalTwo = width + 0.6;
            double realOne = totalOne * totalTwo;
            double realONE = realOne * 7;

            double total1 = rectangle * (lenght / 2) * (lenght / 2);
            double realTotal1 = total1 * 9;
            double totalUSD = realONE + realTotal1;
            double totalBGN = totalUSD * 1.85;

            Console.WriteLine($"{totalUSD:f2} USD");
            Console.WriteLine($"{totalBGN:f2} BGN");
        }
    }
}
