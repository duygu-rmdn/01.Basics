using System;

namespace ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakecount = int.Parse(Console.ReadLine());
            int waferCount = int.Parse(Console.ReadLine());
            int pancakeCuont = int.Parse(Console.ReadLine());

            double totalIncome = days * (cooks * (cakecount * 45.0 + waferCount * 5.80 + pancakeCuont * 3.20));
            double result = totalIncome - totalIncome / 8.0;
            Console.WriteLine($"{result:f2}");

        }
    }
}
