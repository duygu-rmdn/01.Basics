using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double evenMin= int.MaxValue;
            double evenMax = int.MinValue;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += element;
                    if (element < evenMin)
                    {
                        evenMin = element;
                    }
                    if (element > evenMax)
                    {
                        evenMax = element;
                    }
                }
                else
                {
                    oddSum += element;

                    if (element < oddMin)
                    {
                        oddMin = element;
                    }
                    if (element > oddMax)
                    {
                        oddMax = element;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddSum != 0)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            Console.WriteLine($"EvenSum={ evenSum:f2},");
            if (evenSum != 0)
            {
                Console.WriteLine($"EvenMin={ evenMin:f2},");
                Console.WriteLine($"EvenMax={ evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
