using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int MaxNum = int.MinValue;
            
            while (counter <= n)
            {
                int num = int.Parse(Console.ReadLine());
                if(num > MaxNum)
                {
                    MaxNum = num;
                }
                counter++;
            }
            Console.WriteLine(MaxNum);


        }
    }
}
