using System;

namespace Honey_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double honey = flowerCount;

            if (season == "Spring")
            {
                if (flowerType == "Sunflower")
                {
                    honey *= 10;
                }
                else if (flowerType == "Daisy")
                {
                    honey *= 12 * 1.10;
                }
                else if (flowerType == "Lavender")
                {
                    honey *= 12;
                }
                else if (flowerType == "Mint")
                {
                    honey *= 10 * 1.10;
                }
            }
            if (season == "Summer")
            {
                if (flowerType == "Sunflower")
                {
                    honey *= 8 * 1.10;
                }
                else if (flowerType == "Daisy")
                {
                    honey *= 8 * 1.10;
                }
                else if (flowerType == "Lavender")
                {
                    honey *= 8 * 1.10;
                }
                else if (flowerType == "Mint")
                {
                    honey *= 12 * 1.10;
                }
            }
            if (season == "Autumn")
            {
                if (flowerType == "Sunflower")
                {
                    honey *= 12 * 0.95;
                }
                else if (flowerType == "Daisy")
                {
                    honey *= 6 * 0.95;
                }
                else if (flowerType == "Lavender")
                {
                    honey *= 6 * 0.95;
                }
                else if (flowerType == "Mint")
                {
                    honey *= 6 * 0.95;
                }
            }
            Console.WriteLine($"Total honey harvested: {honey:f2}");
        }
    }
}
