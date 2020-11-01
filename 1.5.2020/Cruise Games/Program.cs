using System;

namespace Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int shcore = int.Parse(Console.ReadLine());
            int experiense = 0;

            while (shcore > 0)
            {
                experiense++;
                string type = Console.ReadLine();
                
                if (type == "number section")
                {
                    int num = int.Parse(Console.ReadLine());
                    shcore -= num;
                }
                else if (type == "double ring")
                {
                    int num = int.Parse(Console.ReadLine());
                    shcore -= num * 2;
                }
                else if (type == "triple ring")
                {
                    int num = int.Parse(Console.ReadLine());
                    shcore -= num * 3;
                }
                else if (type == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {experiense} moves!");
                    break;
                }
                if (shcore < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(shcore)}.");
                    break;
                }
            }
            if (shcore == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {experiense} moves!");
                
            }

        }
    }
}

