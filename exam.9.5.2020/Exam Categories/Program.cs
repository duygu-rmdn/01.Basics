using System;

namespace Exam_Categories
{
    class Program
    {
        static void Main(string[] args)
        {
            int complexity = int.Parse(Console.ReadLine());
            int turbulence = int.Parse(Console.ReadLine());
            int paces = int.Parse(Console.ReadLine());
            if (complexity >= 80)
            {
                if (turbulence >= 80)
                {
                    if (paces >= 8)
                    {
                        Console.WriteLine("Legacy");
                    }
                }
                else if (turbulence <= 10)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    if (turbulence >= 50)
                    {
                        if (paces >= 2)
                        {
                            Console.WriteLine("Hard");
                        }
                        else
                        {
                            Console.WriteLine("Regular");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Regular");
                    }
                }
            }
            else if (complexity <= 30 && complexity > 10)
            {
                if (paces <= 1)
                {
                    Console.WriteLine("Easy");
                }
            }
            else if (complexity <= 10)
            {
                Console.WriteLine("Elementary");
            }

            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}
