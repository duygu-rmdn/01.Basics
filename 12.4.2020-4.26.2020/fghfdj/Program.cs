using System;

namespace fghfdj
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int legth = int.Parse(Console.ReadLine());
            int cake = width * legth;
            bool isEnough = false;
            int currPieces = 0;
            int totalPieces = 0;
            string input = Console.ReadLine();

            while (!isEnough)
            {
                if (input == "STOP")
                {
                    Console.WriteLine($"{cake - totalPieces} pieces are left.");
                    return;
                }
                if (totalPieces > cake)
                {
                    break;
                }
                currPieces = int.Parse(input);
                totalPieces += currPieces;

                input = Console.ReadLine();
            }


            Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces - cake)} pieces more.");

        }
    }
}


