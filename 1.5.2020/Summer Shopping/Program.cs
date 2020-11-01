using System;

namespace Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double beachtowel = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double umbrella = beachtowel * 2 / 3;
            double sandals = umbrella * 0.75;
            double bag = (beachtowel + sandals) * 1 / 3;
            double totalPrice = beachtowel + umbrella + sandals + bag;
            totalPrice = totalPrice - (totalPrice * discount / 100.0);
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Annie's sum is {totalPrice:f2} lv. She has {(budget - totalPrice):f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalPrice:f2} lv. She needs {(totalPrice - budget):f2} lv. more.");
            }
        }
    }
}
