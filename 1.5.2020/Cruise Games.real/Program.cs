using System;

namespace Cruise_Games.real
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int couterPlays = int.Parse(Console.ReadLine());
            bool isEnough = false;
            double shcore = 0;
            for (int i = 1; i <= couterPlays; i++)
            {
                int counterV = 1;
                int counterT = 1;
                int counterB = 1;
                string game = Console.ReadLine();
                shcore = double.Parse(Console.ReadLine());
                double totalschore = shcore;
                if (game == "volleyball")
                {
                    totalschore += shcore * 0.07;
                    if (totalschore / counterV > 75)
                    {
                        isEnough = true;
                        counterV++;
                    }
                }
                else if (game == "tennis")
                {
                    totalschore +=  shcore * 0.05;
                    if (totalschore/counterT > 75)
                    {
                        isEnough = true;
                        counterT++;
                    }
                }
                else if (game == "badminton")
                {
                    totalschore += shcore * 0.02;
                    if (totalschore / counterB> 75)
                    {
                        isEnough = true;
                        counterB++;
                    }
                }
            }
                if (isEnough)
                {
                    Console.WriteLine($"Congratulations, {name}! You won the cruise games with {shcore} points.");
                }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {shcore}.");
            }
          
            
        }
    }
}
