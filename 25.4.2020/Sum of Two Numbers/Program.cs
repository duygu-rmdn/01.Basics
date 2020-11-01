using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int count = 0;
            bool isFount = false;
            for (int num1= start; num1 <= end; num1++)
            {
                count++;
                for (int num2 = start; num2 <= end; num2++)
                {
                    if (num1+num2 == magicNum)
                    {
                        x = num1;
                        y = num2;
                        isFount = true;
                        break;
                    }
                }
            }
            if(isFount) 
            {
                Console.WriteLine($"Combination N:{count} ({x} + {y} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
