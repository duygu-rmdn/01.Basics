using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacantionPrise = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrise = 3;
            double bearPrise = 4.10;
            double minionsPrice = 8.20;
            double truckPrice = 2;

            double tottalPrice = puzzle * puzzlePrice + doll * dollPrise + bear * bearPrise + minion * minionsPrice + truck * truckPrice;

            int totalCount = puzzle + doll + bear + minion + truck;
            if (totalCount >= 50)
            {
                tottalPrice -= tottalPrice * 0.25;
            }
            tottalPrice -= tottalPrice * 0.1;
            if (tottalPrice >= vacantionPrise)
            {
                Console.WriteLine($"Yes! {tottalPrice - vacantionPrise:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacantionPrise - tottalPrice:f2} lv needed.");
            }
        }
    }
}
