using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordS = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double far = meters * speed;
            double Time = Math.Floor(meters / 15) * 12.5;
            
            double result = far + Time;

            double need = result - recordS;

            if (recordS > result)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:f2} seconds.");
              
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {need:f2} seconds slower. ");
            }
        }
    }
}
