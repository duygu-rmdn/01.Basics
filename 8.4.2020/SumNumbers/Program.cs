﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
              sum += currNum; 
            }
            Console.WriteLine(sum);
        }
    }
}
