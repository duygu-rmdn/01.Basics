using System;

namespace Beehive_Defense
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCount = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int atack = int.Parse(Console.ReadLine());
            bool beeWin = false;
            bool bearWin = false;
            

            while (!beeWin||!beeWin)
            {
                beesCount -= atack;
                health -= beesCount * 5;
                if (beesCount <100)
                {
                    bearWin = true;
                    break;
                }
                if (health <= 0)
                {
                    beeWin = true;
                    break;
                }
                if (beesCount < 0)
                {
                    beesCount = 0;
                    bearWin = true;
                    break;
                }
            }
            if (beeWin)
            {
                Console.WriteLine($"Beehive won! Bees left {beesCount}.");
            }
            else if (bearWin)
            {
                if (beesCount < 0)
                {
                    beesCount = 0;
                    
                }
                Console.WriteLine($"The bear stole the honey! Bees left {beesCount}.");
            }



        }
    }
}
