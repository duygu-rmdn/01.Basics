using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row<=10; row++)
            {
                for (int col = 0; row <= 10; col++)
                {
                    Console.WriteLine($"{row} * {col} = {row *col}");
                }

            }

        }
    }
}
