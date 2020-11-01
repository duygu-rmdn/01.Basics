using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftNum = 0;
            for (int i = 0; i < n; i++)
            {
                leftNum = leftNum + int.Parse(Console.ReadLine());
            }
            int rightNum = 0;
            for (int i = 0; i < n; i++)
            {
                rightNum = rightNum + int.Parse(Console.ReadLine());
            }
            if (leftNum == rightNum)
            {
                Console.WriteLine($"Yes, sum = " + leftNum);
            }
            else
            {
                int diff = Math.Abs(rightNum - leftNum);
                Console.WriteLine($"No, diff = " + diff);
            }
        }
    }
}
