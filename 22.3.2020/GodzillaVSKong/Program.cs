using System;

namespace GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int states = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decorate = budget * 0.1;
            if (states > 150)
            {
                clothes *= 0.90;
            }
            double result = (clothes  * states) + decorate;
            if (budget > result)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - result):f2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(result - budget):f2} leva more.");
            }
        }
    }
}
