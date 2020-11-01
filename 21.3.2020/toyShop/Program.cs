using System;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double intcome = 0;
            intcome += puzzleCount * 2.60;
            intcome = intcome + dollCount * 3.00;
            intcome += bearCount * 4.10;
            intcome += minionCount * 8.20;
            intcome += truckCount * 2.00;

            int totalToys = puzzleCount + dollCount + bearCount + minionCount + truckCount;

            if (totalToys >= 50)
            {
                intcome = intcome * 0.75;
            }
            intcome *= 0.90;

            if (intcome >= tripPrice)
            {
                double remaindingMoney = intcome - tripPrice;
                Console.WriteLine($"Yes! {remaindingMoney:f2} lv left.");
            }
            else
            {
                double missingMoney = tripPrice - intcome;
                Console.WriteLine($"Not enough money! {missingMoney:f2} lv needed.");
            }
           
        }
    }
}
