﻿using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int strat = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0; 
            for (int i  = strat; i  <= end; i ++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
