using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start ; i <=end; i++)
            {
                int currnum = i;
                int oddSum = 0;
                int evenSum = 0;

                int count = 0;
                while (i != 0)
                {
                    int digit = currnum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit; 
                    }
                    currnum = currnum / 10;
                    count++;
                }
                if (oddSum == evenSum)
                {
                    Console.WriteLine( i);
                }

            }




        }
    }
}
