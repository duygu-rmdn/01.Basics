using System;
using System.ComponentModel;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double sum = 0; 

            while (command != "Start")
            {
                double coins = double.Parse(Console.ReadLine());
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2 )
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();
            }

            string products = Console.ReadLine();
            double price = 0.0;
            while (products != "End")
            {
                products = Console.ReadLine();
                switch (products)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        products = Console.ReadLine();
                        continue;
                }
                if (price > sum )
                {
                    sum -= price;
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {products}");
                }
            }
                Console.WriteLine($"Change: {}");
        }
    }
}
