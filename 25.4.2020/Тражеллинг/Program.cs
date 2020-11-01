using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string dectination = Console.ReadLine();
                if (dectination == "End")
                {
                    break;
                }
                int budged = int.Parse(Console.ReadLine());
                while (budged > 0)
                {
                    int currMoney = int.Parse(Console.ReadLine());
                    budged += currMoney;
                }
                Console.WriteLine($"Going to {dectination}");
            }
        }
    }
}
