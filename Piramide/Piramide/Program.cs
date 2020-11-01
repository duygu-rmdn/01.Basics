using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = 1;
            int currnum = 1;
            bool isBigger = false;
            while (!isBigger)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write(currnum + " ");
                    currnum++;
                    if (currnum > n)
                    {
                        isBigger = true;
                        break;
                    }
                }
                rows++;
                Console.WriteLine();
            }



        }
    }
}
