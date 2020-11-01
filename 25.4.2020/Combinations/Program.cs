using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int x1 = 0; x1 < 100; x1++)
            {
                for (int x2 = 0; x2 < 100; x2++)
                {
                    for (int x3 = 0; x3 < 100; x3++)
                    {
                        if (x1 + x3 + x2 == num)
                        {
                            counter++;
                        }

                    }

                }

            }
            Console.WriteLine(counter);
        }
    }
}
