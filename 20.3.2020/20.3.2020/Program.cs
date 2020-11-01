using System;

namespace _20._3._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double hall = (l * 100) * (w * 100);
            double wardrobe = (a * 100 * a * 100);
            double bench = hall / 10;

            double freePlease = hall - wardrobe - bench;

            double player = freePlease / (40 + 7000);
            double down = Math.Floor(player);


            Console.WriteLine(down);
        }
    }
}
