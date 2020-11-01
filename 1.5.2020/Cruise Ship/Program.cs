using System;

namespace Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string please = Console.ReadLine();
            string type = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double prise = 0.00;
            switch (please)
            {
                case "Mediterranean":
                    if (type == "standard cabin")
                    {
                        prise = 27.50;
                    }
                    else if (type == "cabin with balcony")
                    {
                        prise = 30.20;
                    }
                    else if (type == "apartment")
                    {
                        prise = 40.50;
                    }
                    break;
                case "Adriatic":
                    if (type == "standard cabin")
                    {
                        prise = 22.99;
                    }
                    else if (type == "cabin with balcony")
                    {
                        prise = 25.00;
                    }
                    else if (type == "apartment")
                    {
                        prise = 34.99;
                    }
                    break;
                case "Aegean":
                    if (type == "standard cabin")
                    {
                        prise = 23.00;
                    }
                    else if (type == "cabin with balcony")
                    {
                        prise = 26.60;
                    }
                    else if (type == "apartment")
                    {
                        prise = 39.80;
                    }
                    break;
            }
            if (days > 7)
            {
                prise = prise * 0.75;
            }
            Console.WriteLine($"Annie's holiday in the {please} sea costs {(prise * 4 * days):f2} lv.");
        }
    }
}
