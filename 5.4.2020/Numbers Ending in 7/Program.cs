using System;

namespace Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (maxNum < num)
                {
                    maxNum = num;
                }
            }
            int sumWithoutMax = sum - maxNum;
            if (sumWithoutMax == maxNum )
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMax}");
            }
            else
            {
                 int diff = Math.Abs(maxNum - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+ diff);
            }

        }
    }
}
