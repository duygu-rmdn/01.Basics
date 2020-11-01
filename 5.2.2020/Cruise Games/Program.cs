using System;

namespace Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gameCount = int.Parse(Console.ReadLine());
            int counterV = 0;
            double pointsV = 0;
            double pointsT = 0;
            double pointsB = 0;
            int counterT = 0;
            int counterB = 0;
            double av1 = 0;
            double av2 = 0;
            double av3 = 0;
            double totalPoint = 0;
            for (int i = 0; i < gameCount; i++)
            {
                string game = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());


                if (game == "volleyball")
                {
                    pointsV += points + (points * 0.07);
                    counterV++;
                }
                else if (game == "tennis")
                {
                    pointsT += points + (points * 0.05);
                    counterT++;
                }
                else if (game == "badminton")
                {
                    pointsB += points + (points * 0.02);
                    counterB++;
                }
            }
            totalPoint += Math.Floor(pointsT + pointsB + pointsV);
            av1 += (pointsV / counterV);
            av2 += (pointsT / counterT);
            av3 += (pointsB / counterB);
            if (av1 >= 75 && av2 >= 75 && av3 >= 75)
            {
                Console.WriteLine($"Congratulations, { name}! You won the cruise games with {totalPoint} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {totalPoint}.");
            }
        }
    }
}
