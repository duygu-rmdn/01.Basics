using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double plese = l * hight * wight ;
            double litres = plese * 0.001;
            double totalPercent = percent * 0.01;
            double water = litres*( 1 - totalPercent) ;
            Console.WriteLine($"{water:f3}");
        }
    }
}
