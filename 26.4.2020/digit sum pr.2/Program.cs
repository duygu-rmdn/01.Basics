using System;

namespace digit_sum_pr._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string currnum = i+ " ";
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j <currnum.Length ; j++)
                {
                    int currDigit = int.Parse(currnum[j].ToString());
                }


                if (oddSum == evenSum)
                {
                    Console.Write(i);
                }

            }

            //nottrue




        }
    }
}
