using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double enoughMoneyForVacantion = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;
            while (money < enoughMoneyForVacantion && spendingCounter < 5 )
            {
                string commander = Console.ReadLine();
                double spendingMoney = double.Parse(Console.ReadLine());
                daysCounter++;
                if (commander == "spend")
                {
                    spendingCounter += 1;
                    money -= spendingMoney;
                    if (money <0)
                    {
                        money = 0;
                    }
                }
                else if (commander == "save")
                {
                    money +=spendingMoney ;
                    spendingCounter = 0;
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            if (money >= enoughMoneyForVacantion)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
