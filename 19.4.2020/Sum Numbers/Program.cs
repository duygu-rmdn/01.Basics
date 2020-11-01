using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            while (input != "Stop")
            {
                int currNum = int.Parse(input);
                sum += currNum;
                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
