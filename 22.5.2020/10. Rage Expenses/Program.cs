using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGAme = int.Parse(Console.ReadLine());
            double headsetP = double.Parse(Console.ReadLine());
            double mouseP = double.Parse(Console.ReadLine());
            double keyboardP = double.Parse(Console.ReadLine());
            double displayP = double.Parse(Console.ReadLine());

            double rageEx = 0;

            for (int i = 1; i <= lostGAme; i++)
            {
                if (i % 2 == 0)
                {
                    rageEx += headsetP;
                }

                if (i % 3 == 0 )
                {
                    rageEx += mouseP;
                }
                if (i % 6 == 0)
                {
                    rageEx += keyboardP;
                }
                if (i % 10 == 0)
                {
                    rageEx += displayP;
                }
            }
            Console.WriteLine($"Rage expenses: {rageEx:f2} lv.");
        }
    }
}
