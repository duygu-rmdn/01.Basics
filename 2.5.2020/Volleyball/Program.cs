using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int days = 0;
            double play = 0;
            play += (48 - h) * 3 / 4;
            play += h;
            play += p * 2 / 3;
            if (year == "leap")
            {
                days = 366;
                
               
                play =  play*1.15;
            }
            else
            {
                days = 365;
               
                
            }
            Console.WriteLine(Math.Floor(play));
        }
    }
}
