using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            // цената за НАЕМ зависи от СЕЗОНА и БРОЯТ рибари

            // бюджет - int.
            // сезон - string - "Spring", "Summer", "Autumn", "Winter"
            // брой рибари - int.

            int budget = int.Parse(Console.ReadLine());
            string TimeSeason = Console.ReadLine();
            int CountFishermen = int.Parse(Console.ReadLine());

            double price = 0;

            // пролет - 3000 лв.
            // лято и есен - 4200 лв.
            // зима - 2600 лв.

            switch (TimeSeason)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                    price = 4200;
                    break;
                case "Autumn":
                    price = 4200;
                    break;
                default:
                    price = 2600;
                    break;
            }
            //Ако групата е до 6 човека включително  –  отстъпка от 10%.
            //Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //Ако групата е от 12 нагоре  –  отстъпка от 25 %.

            double discount = 0;

            if (CountFishermen <= 6)
            {
                discount = price * 0.90;
            }
            else if (CountFishermen >= 7 && 11 >= CountFishermen)
            {
                discount = price * 0.85;
            }
            else
            {
                discount = price * 0.75;

            }

            double bonus = CountFishermen % 2;

            double TotalPrice = discount;

            if (CountFishermen % 2 == 0)
            {
                switch (TimeSeason)
                {
                    case "Winter":
                        TotalPrice = discount * 0.95;
                        break;
                    case "Summer":
                        TotalPrice = discount * 0.95;
                        break;
                    case "Spring":
                        TotalPrice = discount * 0.95;
                        break;
                    default:
                        TotalPrice = discount;
                        break;
                }

            }

            if (budget >= TotalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - TotalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {TotalPrice - budget:F2} leva.");
            }


        }
    }
}