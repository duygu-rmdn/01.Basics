using System;

namespace CookinhCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int allCookiesCounter = 0;
            int allCakeCounter = 0;
            int allWafflesCounter = 0;

            int allCount = 0;
            for (int i = 0; i < n ; i++)
            {
                string name = Console.ReadLine();
                int cookiesCounter = 0;
                int cakesCounter = 0;
                int wafflesCouter = 0;

                string type = Console.ReadLine();
                while (type != "Stop baking!")
                {
                    
                    int count = int.Parse(Console.ReadLine());
                    allCount += count;
                    switch (type)
                    {
                        case "cookies":
                            allCookiesCounter += count;
                           cookiesCounter += count;
                            break;
                        case "cakes":
                            allCakeCounter += count;
                             cakesCounter += count;
                            break;
                        case "waffles":
                            allWafflesCounter += count;
                            wafflesCouter += count;
                            break;
                    }
                    type = Console.ReadLine();
                }

                Console.WriteLine($"{name} baked {cookiesCounter} cookies, {cakesCounter} cakes and {wafflesCouter} waffles.");
            }
            int totalCount = allWafflesCounter + allCookiesCounter + allCakeCounter;
            double price = allCookiesCounter * 1.50 + allCakeCounter * 7.80 + allWafflesCounter * 2.30;
            Console.WriteLine($"All bakery sold: { totalCount}");
            Console.WriteLine($"Total sum for charity: {price:f2} lv.");


        }
    }
}
