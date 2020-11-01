using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int animalsCount = int.Parse(Console.ReadLine());

            double dogExpenses = dogCount * 2.50;
            double otherExpenses = animalsCount * 4.0;

            double totalExpenses = dogExpenses + otherExpenses;
            Console.WriteLine($"{totalExpenses:f2}" + " lv.");
        }
    }
}
