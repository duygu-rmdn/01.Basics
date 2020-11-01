using System;

namespace Alcohole
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskiCost = double.Parse(Console.ReadLine());
            double beerKol = double.Parse(Console.ReadLine());
            double vineKol = double.Parse(Console.ReadLine());
            double rakiqKol = double.Parse(Console.ReadLine());
            double wiskiKol = double.Parse(Console.ReadLine());

            double rakiqCost = wiskiCost / 2;
            double vineCost = rakiqCost - (0.4 * rakiqCost);
            double beerCost = rakiqCost - (0.8 * rakiqCost);

            double rakiqtotal = rakiqKol * rakiqCost;
            double vinetotal = vineKol * vineCost;
            double beertotal = beerKol * beerCost;
            double wiskitotal = wiskiKol * wiskiCost;

            double total = rakiqtotal + vinetotal + beertotal + wiskitotal;

            Console.WriteLine($"{total:f2}");
            

        }
    }
}
