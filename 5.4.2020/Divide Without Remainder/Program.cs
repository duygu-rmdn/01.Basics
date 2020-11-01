using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstGroup = 0;
            int secondGroup = 0;
            int thrirdGroup = 0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                
                if (num % 2 == 0)
                {
                    firstGroup++;
                    p1 = (firstGroup * 1.0 / n) * 100.0;
                    Console.WriteLine($"{p1:f2}%");
                }

                if (num % 3 == 0)
                {
                    secondGroup++;
                    p2 = (secondGroup * 1.0 / n) * 100.0;
                    Console.WriteLine($"{p2:f2}%");
                }

                if (num % 4 == 0)
                {
                    thrirdGroup++;
                    p3 = (thrirdGroup * 1.0 / n) * 100.0;
                    Console.WriteLine($"{p3:f2}%");
                }
               
            }
         
        }
    }
}
