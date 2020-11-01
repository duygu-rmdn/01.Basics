using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cake = a * b; 
            bool  isEnoug= false;
            int totalPieces = 0;
            int currP = 0;
            string input = Console.ReadLine();
            while (!isEnoug)
            {
                if (input =="STOP")
                {
                    Console.WriteLine($"{cake - totalPieces} pieces are left.");
                    return;
                }
                if (totalPieces > cake)
                {
                    break;
                }
                currP = int.Parse(input);
                totalPieces += currP;

                input = Console.ReadLine();
            }
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces - cake)} pieces more.");
        }
    }
}
