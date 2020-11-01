using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstGroup = 0;
            int secondGroup = 0;
            int thirdGroup = 0;
            int fourthGroup = 0;
            int fifthGroup = 0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    firstGroup++;
                }
                if (num >= 200 && num < 400)
                {
                    secondGroup++;
                }
                if (num >= 400 && num < 600)
                {
                    thirdGroup++;
                }
                if (num >=600 && num < 800)
                {
                    fourthGroup ++;
                }
                if (num >= 800)
                {
                    fifthGroup ++;
                }
            }
            p1 = (firstGroup *1.0/ n )* 100.00;
            p2 = (secondGroup *1.0/ n )* 100.00;
            p3 = (thirdGroup *1.0/ n )* 100.00;
            p4 = (fourthGroup *1.0/ n )* 100.00;
            p5 = (fifthGroup *1.0/ n )* 100.00;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
