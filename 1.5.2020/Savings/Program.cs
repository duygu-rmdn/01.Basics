using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int mounths = int.Parse(Console.ReadLine());
            double costs = double.Parse(Console.ReadLine());
            double save = input * 0.3;
            double saveM = input - (costs + save);
            double totalsavings = mounths * saveM;
            double percent = saveM / input * 100;
            Console.WriteLine($"She can save {percent:f2}%");
            Console.WriteLine($"{totalsavings:f2}");
        }
    }
}
