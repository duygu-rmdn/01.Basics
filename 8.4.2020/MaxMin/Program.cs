﻿using System;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int smalest = int.MaxValue;
            int biggest = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < smalest)
                {
                    smalest = num;

                }
                if (num > biggest)
                {
                    biggest = num;

                }
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smalest}");
        }
    }
}
